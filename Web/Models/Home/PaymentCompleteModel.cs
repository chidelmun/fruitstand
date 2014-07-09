﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Code.Contracts.Entities;
using Web.Code.Contracts.Entities.ApiModels;

namespace Web.Models.Home
{
	public class PaymentCompleteModel : BaseModel
	{
		public AnticipatedPaymentRepresentation PaymentInfo = new AnticipatedPaymentRepresentation();
		public bool IsError = false;
		public string ErrorMessage = "";
	}
}