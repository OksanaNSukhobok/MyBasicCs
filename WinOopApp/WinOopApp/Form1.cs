using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //***************************************************
            //Пока мы программируем в этой области
            /*
            string myString;
            myString = "Hello, World!";
            txtOutput.Text = myString;
            

            //Инкапсуляция
            
            Person p1 = new Person("Иван", "Петров");
            Person p2 = new Person("Ольга", "Ивановна", "Сергеева");

            txtOutput.Text += p1.FirstName + Environment.NewLine;
            txtOutput.Text+= p2.FirstName + Environment.NewLine;

            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += p1.GetFullName() + Environment.NewLine;
            txtOutput.Text += p2.GetFullName() + Environment.NewLine;
            

            Person p3 = new Person("И", "Петров");
            Person p4 = new Person("О", "И", "Сергеева");
            
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += p3.GetShortName() + Environment.NewLine;
            txtOutput.Text += p4.GetShortName() + Environment.NewLine;
            

            //Наследование
            
            txtOutput.Text += Environment.NewLine;
            
            Driver p5 = new Driver("Петр", "Иванович", "Кузнецов", "12345");
            
            Driver p6 = new Driver("П", "И", "Кузнецов", "12345");
            
            txtOutput.Text += p5.GetFullName() + Environment.NewLine;
            
            txtOutput.Text += p6.GetShortName() + Environment.NewLine;
            
            txtOutput.Text += p5.GetInfo() + Environment.NewLine;
            
            txtOutput.Text += p6.GetInfo() + Environment.NewLine;
            
            //Полиморфизм
            
            txtOutput.Text += Environment.NewLine;
            
            Person[] persons = { p3, p4, p6 };
            foreach (Person person in persons)
            {
                txtOutput.Text += person.GetInfo()+Environment.NewLine;
            }

            
            txtOutput.Text += Environment.NewLine;

            Bird b1 = new Bird("Бескилевые", "Кивиобразные");
            Bird b2 = new Bird("Бескилевые", "Страусообразные");
            Bird b3 = new Bird("Новонебные", "Аистообразные");
            Bird b4 = new Bird("Колибриобразные");
            txtOutput.Text += b1.BirdFullName() + Environment.NewLine;
            txtOutput.Text += b2.BirdFullName() + Environment.NewLine;
            txtOutput.Text += b3.BirdFullName() + Environment.NewLine;
            txtOutput.Text += b4.BirdFullName() + Environment.NewLine;

            Tsaplia b5 = new Tsaplia("Новонебные", "Аистообразные", "Цапля");
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += b1.GetBirdFullName() + Environment.NewLine;
            txtOutput.Text += b2.GetBirdFullName() + Environment.NewLine;
            txtOutput.Text += b3.GetBirdFullName() + Environment.NewLine;
            txtOutput.Text += b4.GetBirdFullName() + Environment.NewLine;
            txtOutput.Text += b5.GetBirdFullName() + Environment.NewLine;
            */

            //Урок 1.10
            
            Divide1(8, 2);
            
            txtOutput.Text += Environment.NewLine;
            Divide2(8, 2);
            Divide2(8, 0);
            
            txtOutput.Text += Environment.NewLine;
            Divide3(8,2);
            Divide3(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide4(8, 2);
            Divide4(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide5(8, 2);
            Divide5(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide6(8, 2);
            Divide6(8, 0);

            txtOutput.Text += Environment.NewLine;
            try
            {
                Divide7(8, 0);
            }
            catch (Exception exc)
            {
                txtOutput.Text += exc.Message + Environment.NewLine;
            }

            txtOutput.Text += Environment.NewLine;
            try
            {
                TestFunction();
            }
            catch (Exception exc)
            {
                txtOutput.Text += exc.Message + Environment.NewLine;
            }

            txtOutput.Text += Environment.NewLine;
            int[] numbers = { 2, 3, 15, 7, 11, 16 };
            GetNumber(numbers, 10);

            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "функция Raqam" + Environment.NewLine;
            Raqam(15, 0);
            
            


        }

    
        // Место для функций

        // Урок 1.10
        //Простейшая обработка без учета ошибок    
        
        void Divide1(int a, int b)
        {
            txtOutput.Text = (a/b).ToString()+Environment.NewLine;
        }
        
        //Используется проверка входных данных
        void Divide2(int a, int b)
        {
            if (b != 0)
            {
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            else
            {
                txtOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
        }
        
        //Используется обработка исключений
        void Divide3(int a, int b)
        {
            try
            {
                //Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception ex) 
            {
                //Блок кода для обрабатки исключений
                txtOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
        }
            
        void Divide4(int a, int b)
        {
            try
            {
                //Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception ex)
            {
                //Блок кода для обработки исключений
                txtOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        //Используется обработка различных исключений
        void Divide5(int a, int b)
        {
            try
            {
                //Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (DivideByZeroException ex)
            {
               //Блок кода для обработки конкретного типа исключений
               txtOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                //Блок кода для обработки остальных исключений
                txtOutput.Text += ex.Message + Environment.NewLine;
            }
        }


        //Используется обработка исключений с finally
        void Divide6(int a, int b)
        {
            try
            {
                //Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception ex)
            {
                //Блок кода для обработки исключений
                txtOutput.Text += ex.Message + Environment.NewLine;
            }
            finally
            {
                //Блок кода, который всегда выполняется по завершению
                txtOutput.Text += "Выполнение завершено" + Environment.NewLine;
            }

        }

        //Используется обработка исключений с повторной генерацией исключения
        void Divide7(int a, int b)
        {
            try
            {
                //Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception ex)
            {
                //Блок кода для обработки исключений
                txtOutput.Text += ex.Message + Environment.NewLine;
                throw;
            }
        }

        //Создание исключения
        void TestFunction()
        {
            throw new ApplicationException("Тестовое исключение");
        }
        
            
        //Попытка обратиться к несуществующему элементу массива
        void GetNumber(int[] arr, int i)
        {
            try
            {
                //Блок, в котором возможны исключения
                txtOutput.Text += "Попытка обратиться к несуществующему элементу массива: "+ arr[i] + Environment.NewLine;
            }
            catch (Exception e)
            {
                //Блок кода для обработки исключений
                txtOutput.Text += "Попытка обратиться к несуществующему элементу массива: " + e.Message + Environment.NewLine;
            }
        }

        //Функция с блоком try - except - finally по выбору
        void Raqam(int a, int b)
        {
            try
            {
                //Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception excep)
            {
                //Блок кода для обработки исключений
                txtOutput.Text += "Деление на ноль!" + Environment.NewLine;
            }
            finally
            {
                //Блок кода, который всегда выполняется по завершению
                txtOutput.Text += "Выполнение завершено" + Environment.NewLine;
            }

        }


        //*************************************************    

    }
}

