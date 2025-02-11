using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW05
{
    public partial class Form1 : Form
    {
        private string path = "Persons.json";
        private List<Person> persons = new List<Person>();

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.GridLines = true;
            listView.Columns.Add("Name", 120);
            listView.Columns.Add("Surname", 150);
            listView.Columns.Add("Age", 60);
            listView.Columns.Add("Group", -2);

            LoadPersonsAsync();
        }
        private async void LoadPersonsAsync()
        {
            await ReadPersons();
            PrintPersons();
        }

        private void AddPerson(Person p)
        {
            persons.Add(p);
        }

        private async void WritePersons()
        {
            string json = JsonSerializer.Serialize(persons);
            await File.WriteAllTextAsync(path, json);
        }

        private async Task ReadPersons()
        {
            if (!File.Exists(path)) persons = new List<Person>();

            try
            {
                string json = await File.ReadAllTextAsync(path);
                persons = JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
            }
            catch
            {
                persons = new List<Person>();
            }
        }

        private void PrintPersons()
        {
            listView.Items.Clear();

            foreach (var p in persons)
            {
                AddItemToList(p);
            }
        }

        private void OutputYoungestPerson()
        {
            if (persons.Count == 0) return;

            Person p = persons
                .OrderBy(p => p.Age)
                .First();
            MessageBox.Show($"Youngest person: {p.Name} {p.Surname}, {p.Age}, {p.Group}");
        }

        private void AddItemToList(Person p)
        {
            ListViewItem item = new ListViewItem(p.Name);
            item.SubItems.Add(p.Surname);
            item.SubItems.Add(p.Age.ToString());
            item.SubItems.Add(p.Group);
            listView.Items.Add(item);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAge.Text, out int age) || age <= 0)
            {
                ShowError("Incorrect age");
                return;
            }

            string name = textBoxName.Text.Trim(),
                   surname = textBoxSurname.Text.Trim(),
                   group = textBoxGroup.Text.Trim();

            if (new[] { name, surname, group }.Any(string.IsNullOrEmpty))
            {
                ShowError("All fields must be filled");
                return;
            }

            Person person = new Person(name, surname, age, group);
            AddPerson(person);

            Task t1 = new Task(WritePersons);
            Task t2 = t1.ContinueWith(_ => PrintPersons());
            try
            {
                t1.Start();
                t2.Wait();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                t1.Dispose();
                t2.Dispose();
                OutputYoungestPerson();
            }
        }
    }
}
