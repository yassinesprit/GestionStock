// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using gestion_stock.entities;

List <Article> stock = new List <Article> ();


static int Recherche(List<Article> l,int r){
    int indice = -1;
    foreach (Article a in l)
    {
        if (a.num_reference == r)
        {
            indice=l.IndexOf (a);
            return  indice;
        }
    }
    return indice;

}

static List<Article> Ajouter(Article a, List<Article> stock)
{
    if (Recherche(stock, a.num_reference) ==-1)
    {
        stock.Add(a);
        Console.WriteLine("ajouté");
        return stock;
    }
    Console.WriteLine("echoué");
    return stock;
}

static List<Article> Delete (List<Article>l,int r)
{
    int indice = Recherche(l, r);
    if (indice >= 0)
    {
        //l.Remove(l[indice]);
        l.RemoveAt(indice);
        Console.WriteLine("supprimé");
    }
    else
    {
        Console.WriteLine("echoué");
    }
    return l;
}


static Article Modifier(List<Article> l, int r, Article art)
{
    int indice= Recherche(l, r);
    if (indice >= 0)
    {
         l[indice]= art;
        Console.WriteLine("modifié");

    }
    else
    {
        Console.WriteLine("echoué");
    }
    return l[indice];
}



static int Recherche_nom(List<Article> l, String r)
{
    int indice = -1;
    foreach (Article a in l)
    {
        if (a.nom == r)
        {
            indice = l.IndexOf(a);
            return indice;
        }
    }
    return indice;

}


static int Recherche_inter_prix(List<Article> l, int r,int p)
{
    int indice = -1;
    foreach (Article a in l)
    {

        
            if (a.prix <= r & a.prix >= p | a.prix <= p & a.prix >= r)
            {
                indice = l.IndexOf(a);
                return indice;
            }
        
        
    }
    return indice;

}

static Article Afficher_list (List<Article> l)
{
    Article list = new Article();
    foreach (Article a in l)
    {
        list = a;
        return a;
    }
    return list;

}

