﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using MixERP.Net.Common.Models.Transactions;
using MixERP.Net.Core.Modules.Inventory.Resources;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.UserControls.Products;
using System;

namespace MixERP.Net.Core.Modules.Inventory
{
    public partial class Transfer : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (ProductViewControl productView = (ProductViewControl)this.Page.LoadControl("~/UserControls/Products/ProductViewControl.ascx"))
            {
                productView.Text = Titles.StockTransferJournal;
                productView.Book = TranBook.Inventory;
                productView.SubBook = SubTranBook.Transfer;
                productView.AddNewUrl = "~/Modules/Inventory/Entry/Transfer.mix";
                productView.PreviewUrl = "~/Modules/Inventory/Reports/InventoryTransferReport.mix";
                productView.ChecklistUrl = "~/Modules/Inventory/Confirmation/Transfer.mix";
                productView.Initialize();

                Placeholder1.Controls.Add(productView);
            }

            base.OnControlLoad(sender, e);
        }
    }
}