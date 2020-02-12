﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comData.DesktopClient.Resources
{
    public class ClienteResource
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
