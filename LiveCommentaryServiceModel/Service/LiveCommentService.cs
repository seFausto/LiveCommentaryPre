using LiveCommentary.Models;
using LiveCommentaryServiceModel.Service;
using Raven.Client.Document;
using System;

namespace LiveCommentaryServiceModel.Business
{
    public interface ILiveCommentService
    {
        Guid AddComment(LiveComment liveComment);
    }

    public class LiveCommentService : ILiveCommentService
    {


        public LiveCommentService()
        {
        }

        public Guid AddComment(LiveComment liveComment)
        {
            var documentStore = new DocumentStore
            {
                Url = "http://localhost:8080",
                DefaultDatabase = "LiveCommentary",
            };

            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                session.Store(liveComment);

                session.SaveChanges();

            }

            return Guid.NewGuid();
        }

        public LiveComment GetComment(Guid guid)
        {
            var result = new LiveComment();

            var documentStore = new DocumentStore
            {
                Url = "http://localhost:8080",
                DefaultDatabase = "LiveCommentary",
            };

            documentStore.Initialize();
            using (var session = documentStore.OpenSession())
            {
                result = session.Load<dynamic>("movies/1");

            }

            return result;
        }
    }
}