#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcConstraintClassificationRelationships.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic; using System.Linq;using Xbim.XbimExtensions.Interfaces;
using Xbim.Ifc2x3.ConstraintResource;

#endregion

namespace Xbim.XbimExtensions.DataProviders
{
    public class IfcConstraintClassificationRelationships
    {
        private readonly IModel _model;

        public IfcConstraintClassificationRelationships(IModel model)
        {
            this._model = model;
        }

        public IEnumerable<IfcConstraintClassificationRelationship> Items
        {
            get { return this._model.Instances.OfType<IfcConstraintClassificationRelationship>(); }
        }
    }
}