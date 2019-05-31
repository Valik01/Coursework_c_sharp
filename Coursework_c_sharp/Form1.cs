using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Coursework_c_sharp
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         deletbut.Enabled = false;
         savebut.Enabled = false;
         nextbut.Enabled = false;
         backbut.Enabled = false;
         redagbut.Enabled = false;
         stateComBox.KeyPress += (sender, e) => e.Handled = true;
         dTim.MaxDate = DateTime.Now;
         dTim.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
         aDD();
      }

      List<CardFile> books = new List<CardFile>();
      int back;
      string tmp;
      
      void add()
      {
         books.Add(new CardFile(
            nameTB.Text,
            authorTB.Text,
            Convert.ToUInt16(yearNumUpDwn.Text),
            pubhousTB.Text,
            Convert.ToUInt16(priceNumUpDwn.Text),
            stateComBox.Text,
            Convert.ToDateTime(dTim.Text)));
      }

       public void aDD ()
      {
         books.Add(new CardFile(
            "С# 4.0",
            "Шилдт",
           2008,
           "THE BIRD",
            800,
            "новое",
            DateTime.Now));
         books.Add(new CardFile(
            "Math",
            "Byr'ak",
           2010,
           "ONPU",
            100,
            "новое",
            DateTime.Now));
         books.Add(new CardFile(
            "Физика",
            "Маслов",
           1999,
           "ФИС",
            34,
            "хорошое",
            DateTime.Now));
         books.Add(new CardFile(
            "MathLab",
            "Фомин",
           2019,
           "123",
            100,
            "отличное",
            DateTime.Now));

         renovation();
      }
      
      private void addbut_Click(object sender, EventArgs e)
      {
         this.add();

         dGV.Rows.Add(
            books.Count,
            nameTB.Text,
            authorTB.Text,
            Convert.ToUInt16(yearNumUpDwn.Text),
            pubhousTB.Text,
            Convert.ToUInt16(priceNumUpDwn.Text),
            stateComBox.Text,
            Convert.ToDateTime(dTim.Text).ToString("dd/MM/yyyy"),
            books.Count);

         tmp += 
            nameTB.Text + "\r\n" +
            authorTB.Text + "\r\n" +
            yearNumUpDwn.Text+ "\r\n" +
            pubhousTB.Text + "\r\n" +
            priceNumUpDwn.Text + "\r\n" +
            stateComBox.Text + "\r\n" +
            dTim.Text + "\r\n\r\n";

         deletbut.Enabled = true;
         savebut.Enabled = true;
         nextbut.Enabled = (books.Count >1) ? true : false;
         backbut.Enabled = (books.Count >= 0) ? true : false;

         yearNumUpDwn.Value = 1995;
         priceNumUpDwn.Value = 0;
         dTim.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));

         nameTB.Clear();
         authorTB.Clear();
         pubhousTB.Clear();
        
         back = books.Count-1;
      }



      private void renovation() 
      {
         int k = 0;
         dGV.Rows.Clear();
         foreach (var book in books)
         {
            dGV.Rows.Add
            (
                 ++k,
                book.Namebk,
                book.Author,
                book.Yearpublish,
                book.Publishhous,
                book.Price,
                book.State,
                book.Date.ToString("dd/MM/yyyy"));
         }
      }
      

      private void delet_Click(object sender, EventArgs e)
      {
         Secondary sec = new Secondary();
         sec.ShowDialog();
         int tmp;
         string r = sec.secondary;
         bool flag = Int32.TryParse(sec.secondary, out tmp);

         if (flag  && tmp >= 1 && tmp <= books.Count )
            books.RemoveAt(tmp-1);
         else
           MessageBox.Show("Некорректно введены данные"); 
          dGV.ClearSelection();
         this.renovation();
         backbut.Enabled = (books.Count <=1) ?  false : true;
         deletbut.Enabled = (books.Count <= 0) ? false:true ;
         nextbut.Enabled = (books.Count <=1) ?  false : true;
         savebut.Enabled = (books.Count <= 0) ? false : true;
      }

      private void savebut_Click(object sender, EventArgs e)
      {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt";
            saveFileDialog1.Title = "Сохраните текстовый файл";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
               return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, tmp);
            MessageBox.Show("Файл сохранен на " + filename);
      }
      

      private void backbut_Click(object sender, EventArgs e)
      {
         if (back >= 0)
         {
            redagbut.Enabled = true;
            redaguvati();
            back--;
         }
      }


      void redaguvati()
      {
       nameTB.Text = books[back].namebk;
         authorTB.Text = books[back].author;
         yearNumUpDwn.Value = books[back].yearpublish;
         pubhousTB.Text = books[back].publishhous;
         priceNumUpDwn.Value = books[back].price;
         stateComBox.Text = books[back].state;
         dTim.Text = Convert.ToString(books[back].date.ToString("dd/MM/yyyy"));
      }  

      private void nextbut_Click(object sender, EventArgs e)
      {
         if (back < books.Count - 1)
         {
            redagbut.Enabled = true;
            back++;
            redaguvati();
         }
      }

      private void redagbut_Click(object sender, EventArgs e)
      {
         back++;
         books[back].namebk = nameTB.Text;
         books[back].author = authorTB.Text;
         books[back].yearpublish = Convert.ToUInt16(yearNumUpDwn.Value);
         books[back].publishhous = pubhousTB.Text;
         books[back].price = Convert.ToUInt16( priceNumUpDwn.Value);
         books[back].state = stateComBox.Text;
         books[back].date = Convert.ToDateTime(dTim.Text);
         renovation();
         redagbut.Enabled = false;
      }

     /* private void open_Click(object sender, EventArgs e)
      {
         var fileContent = string.Empty;
         var filePath = string.Empty;
         int a = 0, i = 0, c = 0;

         using (OpenFileDialog openFileDialog = new OpenFileDialog())
         {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               //Get the path of specified file
               filePath = openFileDialog.FileName;

               //Read the contents of the file into a stream
               var fileStream = openFileDialog.OpenFile();

               StreamReader reader = new StreamReader(fileStream);
               string steam;
               //fileContent = reader.ReadToEnd();

                  while ((steam = reader.ReadLine()) != null)
                  {
                     string temp;
                     temp = null;
                     string stroct;
                     stroct = filePath;
                     for (int f = c; f < stroct.Length; f++)
                     {
                        if (stroct[f] == \n")
                        {
                           c = f + 1;

                           if (a == 0)
                           {
                              books[i].namebk = temp;
                           }

                           if (a == 1)
                           {
                              books[i].author = temp;
                           }

                           if (a == 2)
                           {
                              books[i].yearpublish = Convert.ToUInt32(temp);
                           }

                           if (a == 3)
                           {
                              books[i].publishhous = temp;
                           }

                           if (a == 4)
                           {
                              books[i].price = Convert.ToUInt32(temp);
                           }

                           if (a == 5)
                           {
                              books[i].state = temp;
                           }

                           if (a == 6)
                           {
                              books[i].date =Convert.ToDateTime(temp);
                              a = 0;
                              i++;
                              c = 0;
                           }
                           else
                           {
                              a++;
                           }
                           temp = null;
                        }
                        if (stroct[f] != '\n')
                        {
                           temp += stroct[f];
                        }
                     }
                  }
                  reader.Close();
                  fileStream.Close();
               }
            }
         
         renovation();
        // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
      }
      */
   }                                                                                        
}                                                                                           
                                                                                            
                                                                                            
                                                                                            