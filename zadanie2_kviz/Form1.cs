using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace zadanie2_kviz
{
    public partial class Form1 : Form
    {
        private ArrayList otazky; //zoznam otazok po tom, ako sa nacitaju zo suboru
        private int indexAktualnejOtazky; //otazka s tymto indexom sa zobrazi v okne
        private int pocetSpravnych;
        private int pocetNespravnych;
        private Otazka aktualnaOtazka; //tato otazka sa zobrazi v okne
        private Random rng;


        public Form1()
        {
            InitializeComponent(); //inicializuju sa komponenty v okne
            SetAllControlsFont(this.Controls); //prenastavi sa font vsetkych komponentov 
            schovatTlacidlaMoznosti(); //schovaju sa tlacidla abcd
            btn_dalsiaOtazka.Hide(); //schova sa tlacidlo dalsia otazka
            vycentrujTlacidlo(btn_dalsiaOtazka); //vycentruje sa tlacidlo
            vycentrujTlacidlo(btn_spustiKviz);

            lbl_1.Text = "";
            lbl_info.Text = "";
            lbl_odpovede.Text = "";

            this.otazky = new ArrayList();
            this.indexAktualnejOtazky = -1;
            pocetSpravnych = 0;
            pocetNespravnych = 0;

            rng = new Random(Guid.NewGuid().GetHashCode()); //vytvori sa instancia triedy random s nahodnym seedom
            this.BackgroundImage = SetImageOpacity(Properties.Resources.otaznik, 0.25F); //nastavi sa priehladnost pozadia
        }

        private Image SetImageOpacity(Image image, float opacity) //metoda prevzata z internetu, metoda nastavi priehladnost obrazka
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        //metoda rekurzivne nastavi font vsetkych prvkov ktore obsahuje prvok v parametri metody
        public void SetAllControlsFont(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls);

                ctrl.Font = new Font("Comic Sans MS", ctrl.Font.Size);

            }
        }

        void vycentrujTlacidlo(Button tlacidlo) {
            tlacidlo.Left = (this.ClientSize.Width - tlacidlo.Width) / 2;
        }

        //genericka metoda zamiesa pole
        private T[] Shuffle<T>(T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = this.rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            return array;
        }

        //metoda zamiesa arraylist
        private void Shuffle(ref ArrayList list)
        {
            
            for (int i = list.Count - 1; i >= 0; i--)
            {
                // Note: It's important to only select a number into each index
                // once. Otherwise you'll get bias toward some numbers over others.
                int number = this.rng.Next(i); // Choose an index to swap here
                
                var temp = list[i];
                list[i] = list[number];
                list[number] = temp;

            }
        }


        //tato metoda sa vykona po stlaceni tlacidla na spustenie kvizu
        private void button5_Click(object sender, EventArgs e)
        {
            //inicializuju sa atributy
            this.pocetNespravnych = 0;
            this.pocetSpravnych = 0;
            this.otazky.Clear();
            this.indexAktualnejOtazky = -1;
            btn_dalsiaOtazka.Text = "Ďalšia otázka";

            btn_spustiKviz.Hide();
            zobrazitTlacidlaMoznosti();

            //do pola riadkov sa nacitaju riadky zo suboru, ktore obsahuju otazky
            string[] riadky = File.ReadAllLines("otazky.txt");
            string znenie;
            string moznostA;
            string moznostB;
            string moznostC;
            string moznostD;
            char spravnaMoznost = 'a'; //toto sa neskor aj tak prepise

            //index riadku sa zvacsi o 6, pretoze su 4 moznosti + 1 otazka + 1 prazdny riadok v subore
            for (int indexRiadku = 0; indexRiadku < riadky.Length; indexRiadku += 6) {
            
                znenie = riadky[indexRiadku];
                if (riadky[indexRiadku + 1][0] == '*') //ak na zaciatku riadku je *, tato odpoved je spravna
                {
                    spravnaMoznost = 'a'; //nastavi sa spravna odpoved
                    moznostA = riadky[indexRiadku + 1].Remove(0, 1);
                }
                else {
                    moznostA = riadky[indexRiadku + 1];
                }

                if (riadky[indexRiadku + 2][0] == '*')
                {
                    spravnaMoznost = 'b';
                    moznostB = riadky[indexRiadku + 2].Remove(0, 1);
                }
                else
                {
                    moznostB = riadky[indexRiadku + 2];
                }

                if (riadky[indexRiadku + 3][0] == '*')
                {
                    spravnaMoznost = 'c';
                    moznostC = riadky[indexRiadku + 3].Remove(0, 1);
                }
                else
                {
                    moznostC = riadky[indexRiadku + 3];
                }

                if (riadky[indexRiadku + 4][0] == '*')
                {
                    spravnaMoznost = 'd';
                    moznostD = riadky[indexRiadku + 4].Remove(0, 1);
                }
                else
                {
                    moznostD = riadky[indexRiadku + 4];
                }

                string spravnaMoznostZnenie = ""; //tu sa ulozi znenie spravnej odpovede, budeme potrebovat pri zamiesani pola moznosti
                switch (spravnaMoznost){
                    case 'a':
                        spravnaMoznostZnenie = moznostA;
                        break;

                    case 'b':
                        spravnaMoznostZnenie = moznostB;
                        break;

                    case 'c':
                        spravnaMoznostZnenie = moznostC;
                        break;

                    case 'd':
                        spravnaMoznostZnenie = moznostD;
                        break;

                    default: break;
                }
                
                string[] moznosti = { moznostA, moznostB, moznostC, moznostD };

                
                Shuffle(moznosti); //nahodne sa zamiesaju moznosti, aby bol kviz zakazdym iny


                for(int i = 0; i < moznosti.Length; i++){
                    if (moznosti[i].Equals(spravnaMoznostZnenie)) {
                        spravnaMoznost = Convert.ToChar(((int)'a') + i); //namapuje sa spravna moznost k zamiesanemu polu
                    }
                }

                //vytvori sa nova otazka
                Otazka novaOtazka = new Otazka(znenie, moznosti[0], moznosti[1], 
                    moznosti[2], moznosti[3], spravnaMoznost);
                otazky.Add(novaOtazka); //otazka sa prida do zoznamu otazok
                
            }
            //po pridani vsetkych otazok do zoznamu sa este tento zoznam zamiesa

            Shuffle(ref this.otazky);

            //zisti sa 1. otazka
            Otazka dalsiaOtazka = dajDalsiuOtazku();
            if (dalsiaOtazka == null)
            {
                koniecKvizu();
            }
            else {
                //tu sa vypise do labelu, do okna
                this.lbl_1.Text = dalsiaOtazka.getZnenie();
                this.lbl_odpovede.Text = dalsiaOtazka.getOdpovede();
            }
            
        }

        //pri skonceni kvizu sa zobrazi pocet spravnych a nespravnych odpovedi
        void koniecKvizu() {
            lbl_1.Text = "Počet správnych odpovedí: " + this.pocetSpravnych + "\n" +
                            "Počet nesprávnych odpovedí: " + this.pocetNespravnych;
            btn_spustiKviz.Show();
        }

        Otazka dajDalsiuOtazku() {
            ++indexAktualnejOtazky; //zvysi sa index aktualnej otazky
            if (indexAktualnejOtazky >= otazky.Count) //ak je vacsi/rovny ako pocet otazok
            {
                //vrati sa null
                return this.aktualnaOtazka = null;
            }
            else {
                //inak sa vrati aktualna otazka
                return this.aktualnaOtazka = ((Otazka)otazky[indexAktualnejOtazky]);
            }
        }

        //skontroluje sa zvolena odpoved
        private void skontrolujOdpoved(char zvolenaOdpoved) {
            if (((Otazka)otazky[indexAktualnejOtazky]).getSpravnaMoznost() == zvolenaOdpoved)
            {
                //odpoved je spravna
                lbl_info.ForeColor = Color.Green;
                lbl_info.Text = "Správne";
                this.pocetSpravnych++;
            }
            else {

                //odpoved je nespranvna
                lbl_info.ForeColor = Color.Red;
                lbl_info.Text = "Nesprávne\nSprávna odpoveď: " + ((Otazka)otazky[indexAktualnejOtazky]).getSpravnaMoznost();
                this.pocetNespravnych++;
            }
        }

        private void schovatTlacidlaMoznosti() {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
        }

        private void zobrazitTlacidlaMoznosti()
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
        }

        //toto sa vykona pri kazdom kliknuti tlacidla abcd
        private void buttonClick() {
            schovatTlacidlaMoznosti();
            btn_dalsiaOtazka.Show();
            dajDalsiuOtazku();
            if (aktualnaOtazka == null) //ak uz neexistuje dalsia otazka
            {
                //text tlacidla dalsej otazky sa zmeni na toto
                btn_dalsiaOtazka.Text = "Sumár";
            }
        }

        //kliknutie na tlacidlo s moznostou a
        private void button1_Click(object sender, EventArgs e)
        {
            skontrolujOdpoved('a');
            buttonClick();
        }

        //kliknutie na tlacidlo s moznostou b
        private void button2_Click(object sender, EventArgs e)
        {
            skontrolujOdpoved('b');
            buttonClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skontrolujOdpoved('c');
            buttonClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skontrolujOdpoved('d');
            buttonClick();
        }

        //kliknutie na tlacidlo dalsia otazka
        private void btn_dalsiaOtazka_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "";
            btn_dalsiaOtazka.Hide(); //schova sa toto tlacidlo
            
            if (this.aktualnaOtazka == null) //ak uz dalsia otazka neexistuje
            {
                //schovaju sa tlacidla abcd a ukonci sa kviz
                this.lbl_odpovede.Text = "";
                schovatTlacidlaMoznosti();
                koniecKvizu();
            }
            else
            {
                //ak existuje dalsia otazka, vypise sa a zobrazia sa tlacidla s moznostami
                zobrazitTlacidlaMoznosti();
                this.lbl_1.Text = this.aktualnaOtazka.getZnenie();
                this.lbl_odpovede.Text = this.aktualnaOtazka.getOdpovede();
            }
        }
    }
}
