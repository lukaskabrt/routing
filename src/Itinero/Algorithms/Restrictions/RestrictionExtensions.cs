﻿/*
 *  Licensed to SharpSoftware under one or more contributor
 *  license agreements. See the NOTICE file distributed with this work for 
 *  additional information regarding copyright ownership.
 * 
 *  SharpSoftware licenses this file to you under the Apache License, 
 *  Version 2.0 (the "License"); you may not use this file except in 
 *  compliance with the License. You may obtain a copy of the License at
 * 
 *       http://www.apache.org/licenses/LICENSE-2.0
 * 
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

namespace Itinero.Algorithms.Restrictions
{
    /// <summary>
    /// Contains extension methods for restrictions.
    /// </summary>
    public static class RestrictionExtensions
    {
        /// <summary>
        /// Adds a new restriction.
        /// </summary>
        public static void Add(this RestrictionCollection restrictions, uint vertex1)
        {
            restrictions.Add(new Restriction(vertex1));
        }

        /// <summary>
        /// Adds a new restriction.
        /// </summary>
        public static void Add(this RestrictionCollection restrictions, uint vertex1, uint vertex2)
        {
            restrictions.Add(new Restriction(vertex1, vertex2));
        }

        /// <summary>
        /// Adds a new restriction.
        /// </summary>
        public static void Add(this RestrictionCollection restrictions, uint vertex1, uint vertex2, uint vertex3)
        {
            restrictions.Add(new Restriction(vertex1, vertex2, vertex3));
        }
    }
}