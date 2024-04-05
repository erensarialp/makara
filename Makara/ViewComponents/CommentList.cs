using Microsoft.AspNetCore.Mvc;
using StajProje.Models;
using System.Collections.Generic;

namespace StajProje.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					Username="Eren"
				},
				new UserComment
				{
					ID= 2,
					Username="Mesut"
				},
				new UserComment
				{
					ID = 3,
					Username="Ayse"
				}

			};

			return View(commentvalues);

		}
	}
}
