﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace visa.Models
{
    public class EmailTemplate
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Template { get; set; }
     

    }
}