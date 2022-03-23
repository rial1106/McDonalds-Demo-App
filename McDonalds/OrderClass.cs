namespace McDonalds
{
    class OrderClass
    {
        public OrderClass(int n_burgers, int n_chips, int n_nuggets, int n_drinks)
        {
            this.n_burgers = n_burgers;
            this.n_chips = n_chips;
            this.n_nuggets = n_nuggets;
            this.n_drinks = n_drinks;
            this.n_cost = getCost();
        }

        public int n_burgers { get; set; }
        public int n_chips { get; set; }
        public int n_nuggets { get; set; }
        public int n_drinks { get; set; }
        public int n_cost { get; set; }

        private int getCost()
        {
            int cost = 0;

            cost += n_burgers * 35;
            cost += n_chips * 15;
            cost += n_drinks * 20;
            cost += n_nuggets * 25;

            return cost;
        }
    }
}
