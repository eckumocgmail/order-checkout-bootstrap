﻿using ApplicationCommon.CommonServices.CommonResources;
using ApplicationCommon.CommonTypes;


using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCommon.CommonResources
{
    /// <summary>
    /// Служба управления ресурсами
    /// </summary>
    public class ResourcesService
    {
        private readonly ApplicationDbContext _context;


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context"></param>
        public ResourcesService(ApplicationDbContext context)
        {
            _context = context;
        }




        /// <summary>
        /// Выполняет сохранение каталога в базу данных
        /// </summary>
        /// <param name="fileCatalog"></param>
        public void Save( TypeCatalog fileCatalog )
        {
            Dictionary<string, FileCatalog> catalogs = new Dictionary<string, FileCatalog>();
            fileCatalog.DoBroadcastToBrothers<TypeCatalog>((TypeCatalog p) => {
                //_context.
                FileCatalog catalog =
                    catalogs[p.GetPath("\\")] = 
                        new FileCatalog(p.Name); 
                if(p.Parent != null)
                {
                    catalog.Parent = catalogs[p.Parent.GetPath("\\")];
                }
                foreach(TypeFile file in p.Item.Values)
                {
                    FileResource resource = new FileResource(file);
                    catalog.Files.Add(resource);
                    _context.FileResources.Add(resource);
                }
                _context.FileCatalogs.Add(catalogs[p.GetPath("\\")]);
            });
            _context.SaveChanges();
        }
    }
}
