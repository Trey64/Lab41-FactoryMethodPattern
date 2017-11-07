﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom.Classes
{
    public class DocumentsFactory
    {
        public Pages CreateDocuments(string docType)
        {
            Pages page = new Pages();

            switch (docType)
            {
                case "Resume":
                    Console.WriteLine("Resume is on the way!");
                    page = new ResumePage();
                    break;
                case "Report":
                    Console.WriteLine("Report is being created!");
                    page = new ReportPage();
                    break;
                default:
                    break;
            }
            return page;
        }
    }
}