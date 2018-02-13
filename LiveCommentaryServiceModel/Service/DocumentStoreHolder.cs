using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveCommentaryServiceModel.Service
{
    public static class DocumentStoreHolder
    {
        public static readonly IDocumentStore Store =
            new DocumentStore
            {
                Url = "http://localhost:8080",
                DefaultDatabase = "LiveCommentary",
            };


    }
}
