using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    public class Rationnel
    {
        private int num = 0;
        private int den = 1;
        public int Num 
        { 
            get { return num; } 
            set { num = value; }
        }   
        
        public int Den
        {
            get { return den; }
            set { den = value; }
        }
        ~Rationnel() { }

        public Rationnel()
        {
        }
        public Rationnel(int num)
        {
            this.num = num;
        }
        public Rationnel(int n, int d)
        {
            num = n;
            den = d;
        }

        public Rationnel Somme(Rationnel r)
        {
            Rationnel res = new Rationnel();
            res.Num = this.Num * r.Den + r.Num * this.Den;
            res.Den = this.Den*r.Den;

            return res;
        }
        public Rationnel Somme(int numerateur, int denominateur)
        {
            Rationnel res = new Rationnel();
            res.Num = this.Num * denominateur + numerateur * this.Den;
            res.Den = this.Den * denominateur;

            return res;
        }

        public Rationnel Produit(Rationnel r)
        {
            Rationnel res = new Rationnel()
            {
                Num = this.Num * r.Num, Den = this.Den*r.Den
            };

            return res;
        }

        public Rationnel Produit(int numerateur, int denominateur)
        {
            Rationnel res = new Rationnel();
            res.Num = numerateur * this.Num;
            res.Den = this.Den*denominateur;

            return res;
        }

        public Rationnel Inverse()
        {
            Rationnel inv = new Rationnel();
            inv.Num = this.Den;
            inv.Den = this.Num;
            return inv;
        }
       

        public void Afficher()
        {
            Console.WriteLine("RATIONNEL({0}/{1})", this.Num, this.Den);
        }

        static void Main(string[] args)
        {
            Rationnel r1 = new Rationnel(4,7);
            Rationnel r2 = new Rationnel(5,3);
            Rationnel r3 = r1.Somme(r2);
            Rationnel r4 = r1.Somme(3, 9);
            r1.Afficher();
            r2.Afficher();
            r3.Afficher();
            Rationnel inv = new Rationnel();
            inv = r1.Inverse();
            Console.WriteLine("inverse de r1 : ");
            inv.Afficher();
            Rationnel prod = new Rationnel();
            prod = r1.Produit(r2);
            Console.WriteLine("Produit r1xr2 :");
            prod.Afficher();
        }


    }



}
