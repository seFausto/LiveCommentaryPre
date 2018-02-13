using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveCommentary.Models;


namespace LiveCommentaryServiceModel.Business
{
    public class LiveCommentBusiness
    {
        private LiveCommentService _liveCommentService;

        public LiveCommentBusiness(LiveCommentService liveCommentService)
        {
            _liveCommentService = liveCommentService;
        }

        public LiveCommentBusiness()
        {
            _liveCommentService = new LiveCommentService();
        }


        public Guid NewComment(LiveComment comment = null, string movieName = "", string userName="")
        {

            var newComment = new LiveComment
            {  
                Comment = "this is a test"               
            };

            //add comment, returnd new guid
            var result = _liveCommentService.AddComment(newComment);


            return Guid.NewGuid();
        }

        public LiveComment GetComment(Guid guid)
        {
            var result = new LiveComment();

            result = _liveCommentService.GetComment(guid);

            return result;
        }

    }
}
