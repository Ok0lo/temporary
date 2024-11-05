namespace PTask3_22
{
    class MyItem
    {
        public MyItem() : this(string.Empty, string.Empty, 1, .1f) { }

        public MyItem(string name, string directorSurname, 
            int productsNumber, double averageYearIncome)
        {
            Name = name;
            DirectorSurname = directorSurname;
            ProductsNumber = productsNumber;
            AverageYearIncome = averageYearIncome;
        }

        public string Name;
        public string DirectorSurname;
        public int ProductsNumber;
        public double AverageYearIncome;
           
        public override string ToString()
        {
            return $"<{Name}> <{DirectorSurname}> <{ProductsNumber}> <{AverageYearIncome}>";
        }
    }
}