using System;
using Nancy;
using Nancy.ModelBinding;
using LiveCommentary.Models;
using LiveCommentaryServiceModel.Business;

namespace LiveCommentaryServiceModel.Modules
{
    public class CommentModule : NancyModule
    {
        public CommentModule()
        {
            Get("/", args => "List of Movies");

            Get("/movie/{name}", args => {
                var liveCommentBusiness = new LiveCommentBusiness();

                liveCommentBusiness.NewComment();


                //var d = liveCommentBusiness.GetComment(new Guid("c8281bad-dc52-424b-aebd-65759a0d8cbb"));

                return "Test";
            });

            Post("/movie/{movieName}/{userName}", args =>
             {
                 var comment = this.Bind<LiveComment>();

                 var movieName = args.movieName;
                 var userName = args.userName;

                 var liveCommentBusiness = new LiveCommentBusiness();

                 //liveCommentBusiness.NewComment(comment, movieName, userName);


                 var d = liveCommentBusiness.GetComment(new Guid("c8281bad-dc52-424b-aebd-65759a0d8cbb"));
                //save comment


                return HttpStatusCode.OK;
             });


        }

    }
}
