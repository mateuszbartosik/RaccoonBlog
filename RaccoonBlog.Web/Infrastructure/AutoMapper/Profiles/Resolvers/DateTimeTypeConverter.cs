using System;
using AutoMapper;

namespace RaccoonBlog.Web.Infrastructure.AutoMapper.Profiles.Resolvers
{
	public class DateTimeTypeConverter : ITypeConverter<DateTimeOffset, DateTime>
	{
	    public DateTime Convert(DateTimeOffset source, DateTime destination, ResolutionContext context)
	    {
	        return source.DateTime;
	    }
	}
}
