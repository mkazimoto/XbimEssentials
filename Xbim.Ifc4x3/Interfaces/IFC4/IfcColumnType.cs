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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcColumnType : IIfcColumnType
	{

		[CrossSchemaAttribute(typeof(IIfcColumnType), 10)]
		Ifc4.Interfaces.IfcColumnTypeEnum IIfcColumnType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcColumnTypeEnum.COLUMN:
						return Ifc4.Interfaces.IfcColumnTypeEnum.COLUMN;
					case IfcColumnTypeEnum.PILASTER:
						return Ifc4.Interfaces.IfcColumnTypeEnum.PILASTER;
					case IfcColumnTypeEnum.PIERSTEM:
						//## Handle translation of PIERSTEM member from IfcColumnTypeEnum in property PredefinedType
						//TODO: Handle translation of PIERSTEM member from IfcColumnTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcColumnTypeEnum.PIERSTEM_SEGMENT:
						//## Handle translation of PIERSTEM_SEGMENT member from IfcColumnTypeEnum in property PredefinedType
						//TODO: Handle translation of PIERSTEM_SEGMENT member from IfcColumnTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcColumnTypeEnum.STANDCOLUMN:
						//## Handle translation of STANDCOLUMN member from IfcColumnTypeEnum in property PredefinedType
						//TODO: Handle translation of STANDCOLUMN member from IfcColumnTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcColumnTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcColumnTypeEnum.USERDEFINED;
					case IfcColumnTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcColumnTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcColumnTypeEnum.COLUMN:
						PredefinedType = IfcColumnTypeEnum.COLUMN;
						return;
					case Ifc4.Interfaces.IfcColumnTypeEnum.PILASTER:
						PredefinedType = IfcColumnTypeEnum.PILASTER;
						return;
					case Ifc4.Interfaces.IfcColumnTypeEnum.USERDEFINED:
						PredefinedType = IfcColumnTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcColumnTypeEnum.NOTDEFINED:
						PredefinedType = IfcColumnTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}