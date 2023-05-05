using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
namespace TRPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "ТЕКСТ";

            using (ApplicationContext db = new ApplicationContext())
            {
               
                
                //product abb = new product { kmat = "y125896m468ktp", nmat = "Кабель ABB 26*17 0,5", krt=0.5};
                //product acdd = new product { kmat = "522146fn956", nmat = "Кабель ACDD 15*1 1", krt = 1 };

                // добавляем их в бд
                //db.products.Add(abb);
                //db.products.Add(acdd);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var products = db.products.ToList();
                Console.WriteLine("Список объектов:");
                foreach (product u in products)
                {
                    Console.WriteLine($"{u.Id}.{u.kmat} - {u.nmat} - {u.krt} - {u.len}");
                }
            }


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}