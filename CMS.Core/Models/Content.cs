﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Models;
public class Content
{
    [Key]
    public int ContentId { get; set; }
    public string ContentType { get; set; }
}

