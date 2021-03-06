﻿using CloudBust.Application.Models;
using Orchard.Security;
using System;
using System.Collections.Generic;

namespace CloudBust.Dashboard.ViewModels
{
    public class TableViewModel
    {
        public IEnumerable<ApplicationRecord> Applications { get; set; }
        public IUser User { get; set; }
        public ApplicationDataTableRecord DataTable { get; set; }
        public IEnumerable<FieldRecord> Fields { get; set; }
        public int Page { get; set; }
        public bool afterPost { get; set; }
        public Uri Uri { get; set; }
        public dynamic Pager { get; set; }
    }
}