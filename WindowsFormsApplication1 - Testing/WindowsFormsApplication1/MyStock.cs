using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class MyStock
    {
        private String stockName, stockSpecs, stockType, useageType;
        private int stockNo, stockSize, stockQty, qtySold;
        private double stockCost, stockPrice, totalCost;

        public MyStock()
        {
            stockName = "";
            stockSpecs = "";
            stockType = "";
            stockSize = 0;
            stockQty = 0;
            qtySold = 0;
            stockCost = 0;
            stockPrice = 0;
            useageType = "";
            totalCost = stockCost * stockQty;
        }

        public MyStock(String stockName, String stockSpecs, String stockType, int stockSize, int stockQty, int qtySold,  double stockCost, double stockPrice, string useageType)
        {
            this.stockName = stockName;
            this.stockSpecs = stockSpecs;
            this.stockType = stockType;
            this.stockSize = stockSize;
            this.stockQty = stockQty;
            this.qtySold = qtySold;
            this.stockCost = stockCost;
            this.stockPrice = stockPrice;
            this.useageType = useageType;
            this.totalCost = stockCost * stockQty;
        }

        public int StockNo { get => stockNo; set => stockNo = value; }
        public string StockName { get => stockName; set => stockName = value; }
        public string StockSpecs { get => stockSpecs; set => stockSpecs = value; }
        public string StockType { get => stockType; set => stockType = value; }
        public int StockSize { get => stockSize; set => stockSize = value; }
        public int StockQty { get => stockQty; set => stockQty = value; }
        public int QtySold { get => qtySold; set => qtySold = value; }
        public double StockCost { get => stockCost; set => stockCost = value; }
        public double StockPrice { get => stockPrice; set => stockPrice = value; }
        public string UseageType { get => useageType; set => useageType = value; }
        public double TotalCost { get => totalCost; }
    }
}
