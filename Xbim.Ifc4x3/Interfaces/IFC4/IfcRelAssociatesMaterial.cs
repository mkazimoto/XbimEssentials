// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcRelAssociatesMaterial : IIfcRelAssociatesMaterial
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssociatesMaterial), 6)]
		IIfcMaterialSelect IIfcRelAssociatesMaterial.RelatingMaterial 
		{ 
			get
			{
				if (RelatingMaterial == null) return null;
				var ifcmaterialdefinition = RelatingMaterial as MaterialResource.IfcMaterialDefinition;
				if (ifcmaterialdefinition != null) 
					return ifcmaterialdefinition;
				var ifcmateriallist = RelatingMaterial as MaterialResource.IfcMaterialList;
				if (ifcmateriallist != null) 
					return ifcmateriallist;
				var ifcmaterialusagedefinition = RelatingMaterial as MaterialResource.IfcMaterialUsageDefinition;
				if (ifcmaterialusagedefinition != null) 
					return ifcmaterialusagedefinition;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RelatingMaterial = null;
					return;
				}	
				var ifcmaterialdefinition = value as MaterialResource.IfcMaterialDefinition;
				if (ifcmaterialdefinition != null) 
				{
					RelatingMaterial = ifcmaterialdefinition;
					return;
				}
				var ifcmateriallist = value as MaterialResource.IfcMaterialList;
				if (ifcmateriallist != null) 
				{
					RelatingMaterial = ifcmateriallist;
					return;
				}
				var ifcmaterialusagedefinition = value as MaterialResource.IfcMaterialUsageDefinition;
				if (ifcmaterialusagedefinition != null) 
				{
					RelatingMaterial = ifcmaterialusagedefinition;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}