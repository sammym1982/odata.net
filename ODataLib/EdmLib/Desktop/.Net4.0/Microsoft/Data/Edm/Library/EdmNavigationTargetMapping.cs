//   OData .NET Libraries ver. 5.6.3
//   Copyright (c) Microsoft Corporation
//   All rights reserved. 
//   MIT License
//   Permission is hereby granted, free of charge, to any person obtaining a copy of
//   this software and associated documentation files (the "Software"), to deal in
//   the Software without restriction, including without limitation the rights to use,
//   copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
//   Software, and to permit persons to whom the Software is furnished to do so,
//   subject to the following conditions:

//   The above copyright notice and this permission notice shall be included in all
//   copies or substantial portions of the Software.

//   THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
//   FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
//   COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
//   IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//   CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Data.Edm.Library
{
    /// <summary>
    /// Represents a mapping from an EDM navigation property to an entity set.
    /// </summary>
    public class EdmNavigationTargetMapping : IEdmNavigationTargetMapping
    {
        private IEdmNavigationProperty navigationProperty;
        private IEdmEntitySet targetEntitySet;

        /// <summary>
        /// Creates a new navigation target mapping.
        /// </summary>
        /// <param name="navigationProperty">The navigation property.</param>
        /// <param name="targetEntitySet">The entity set that the navigation propertion targets.</param>
        public EdmNavigationTargetMapping(IEdmNavigationProperty navigationProperty, IEdmEntitySet targetEntitySet)
        {
            this.navigationProperty = navigationProperty;
            this.targetEntitySet = targetEntitySet;
        }

        /// <summary>
        /// Gets the navigation property.
        /// </summary>
        public IEdmNavigationProperty NavigationProperty
        {
            get { return this.navigationProperty; }
        }

        /// <summary>
        /// Gets the target entity set.
        /// </summary>
        public IEdmEntitySet TargetEntitySet
        {
            get { return this.targetEntitySet; }
        }
    }
}