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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcStair : IIfcStair
	{
		Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum? IIfcStair.PredefinedType 
		{ 
			get
			{
				switch (ShapeType)
				{
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.STRAIGHT_RUN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.STRAIGHT_RUN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.QUARTER_WINDING_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.QUARTER_WINDING_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.QUARTER_TURN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.QUARTER_TURN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.HALF_WINDING_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.HALF_WINDING_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.HALF_TURN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.HALF_TURN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.SPIRAL_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.SPIRAL_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.DOUBLE_RETURN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.DOUBLE_RETURN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.CURVED_RUN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.CURVED_RUN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.TWO_CURVED_RUN_STAIR:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.TWO_CURVED_RUN_STAIR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.USERDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcStairTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcStairTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}