using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediabutik_Lab4_1
{
    class Kvitto
    {
        public uint Kvitto_Id { get; set; }
        public DateTime Datum { get; set; }
        public Produkt_list Varor;

        public Kvitto()
        {


        }
        public void Skriv_ut_kvitto_pdf(string filepath)
        {
            
            string Id_str = "Kvitto Id = " + this.Kvitto_Id.ToString();

            if (filepath.Trim().Length == 0)
            {
                filepath = "Kvitto_Id_"+ this.Kvitto_Id.ToString()+".txt";
            }

            if (File.Exists(@filepath))
            {
                File.Delete(@filepath);
            }

            string Date_Time = DateTime.Now.ToString();

            string Separation_str = "*********************************************************";

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filepath, true))
            {
                file.WriteLine(Separation_str);
                file.WriteLine(Separation_str);
                file.WriteLine(Separation_str);
                file.WriteLine(" ");
                file.WriteLine(Id_str);
                file.WriteLine(" ");
                file.WriteLine(Separation_str);
                file.WriteLine(" ");
                file.WriteLine(Date_Time);
                file.WriteLine(" ");
                file.WriteLine(Separation_str);
                file.WriteLine(" ");
                file.WriteLine("Varor: Nr, Namn, Typ, Antal, pris per styck. ");
                file.WriteLine(" ");
                file.WriteLine(Separation_str);
                file.WriteLine(" ");

                string nr;
                string Name;
                string Type;
                string Antal;
                string Pris;
                double pris_acc = 0;
                uint varor_acc = 0;
                string string_to_write;

                for (var i = 0; i < this.Varor.AllProdukts.Count; i++)
                {
                    nr = (i + 1).ToString();
                    Name = this.Varor.AllProdukts[i].Name;
                    Type = this.Varor.AllProdukts[i].Produkt_type.ToString();
                    Antal = this.Varor.AllProdukts[i].Antal.ToString();
                    Pris = this.Varor.AllProdukts[i].Price.ToString();

                    varor_acc += this.Varor.AllProdukts[i].Antal;
                    pris_acc += this.Varor.AllProdukts[i].Price* this.Varor.AllProdukts[i].Antal;

                    string_to_write = nr + " | " + Name + " | " + Type + " | " + Antal + "st. | " + Pris + ":- ;";
                    file.WriteLine(string_to_write);
                    file.WriteLine(" ");
                    file.WriteLine(Separation_str);
                    file.WriteLine(" ");

                }

                string_to_write = "ANTAL VAROR: " + varor_acc.ToString()+ " ;";
                file.WriteLine(string_to_write);
                file.WriteLine(" ");
                file.WriteLine(Separation_str);
                file.WriteLine(" ");

                string_to_write = "TOTALT PRIS: " + pris_acc.ToString() + " ;";
                file.WriteLine(string_to_write);
                file.WriteLine(" ");
                file.WriteLine(Separation_str);
                file.WriteLine(Separation_str);
                file.WriteLine(Separation_str);
            }

            Print_silent_or_pdf Print1 = new Print_silent_or_pdf();

            Print1.FilePath = filepath;
            Print1.Printing(filepath);


        }

       
    }

}
