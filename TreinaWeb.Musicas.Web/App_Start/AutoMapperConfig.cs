﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreinaWeb.Musicas.Web.AutoMapper;

namespace TreinaWeb.Musicas.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioParaViewModelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}