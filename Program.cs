namespace BOUTIQUE__exo
{
  class Program
    {
    static void Main(string[] args)
        {
            //les variables 
            string article;
            double prix;
            int quantite;

            double prixTotalHT;
            double prixTotalTTC;

            //demande à l'utilisateur de saisir 
            Console.WriteLine("Donnez le nom de l'article : ");
            article =Console.ReadLine(); 
      
            Console.WriteLine("Donnez le prix unitaire ");
            prix= Convert.ToDouble(Console.ReadLine());
  
            Console.WriteLine("Donnez la quantité :");
            quantite= Convert.ToInt32(Console.ReadLine());

      
            // calculs : prix total en HT 
            prixTotalHT = prix * quantite;

            //TVA 18%
            prixTotalTTC = prixTotalHT + (prixTotalHT * 0.18);
       
            //Affichage
            Console.WriteLine("Article : " + article );
            Console.WriteLine("Total TTC : "+ prixTotalTTC + "FCFA");
        }
    }
}
