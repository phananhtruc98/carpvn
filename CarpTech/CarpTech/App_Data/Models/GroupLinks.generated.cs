//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.7.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Group Links</summary>
	[PublishedModel("groupLinks")]
	public partial class GroupLinks : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const string ModelTypeAlias = "groupLinks";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GroupLinks, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public GroupLinks(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Contents
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("contents")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> Contents => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("contents");

		///<summary>
		/// Group Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("groupTitle")]
		public string GroupTitle => this.Value<string>("groupTitle");
	}
}
