﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Web.Code.Contracts.Entities;
using Web.Code.Contracts.Entities.ApiModels;

namespace Web.Models.Home
{
	public class BrowseProductsModel : BaseModel
	{
		public List<Product> Products = new List<Product>();
		public int TaxPercentage = 0;
		public List<Merchant> Merchants = new List<Merchant>();
		public Merchant CurrentMerchant = new Merchant();
	}
}