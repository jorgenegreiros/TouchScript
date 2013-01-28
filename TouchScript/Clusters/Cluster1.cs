﻿/*
 * Copyright (C) 2012 Interactive Lab
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the 
 * 
 */

using UnityEngine;

namespace TouchScript.Clusters {
    /// <summary>
    /// Cluster of all points.
    /// Basically a centroid of points.
    /// </summary>
    public class Cluster1 : Cluster {
        #region Public methods

        /// <summary>
        /// Indicates that this cluster instance represents a valid cluster.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance represents a valid cluster; otherwise, <c>false</c>.
        /// </value>
        public bool HasCluster {
            get { return Points.Count > 0; }
        }

        /// <summary>
        /// Gets the center position.
        /// </summary>
        /// <returns>Centroid of all points.</returns>
        public Vector2 GetCenterPosition() {
            return getCenterPosition(Points);
        }

        /// <summary>
        /// Gets the previous center position.
        /// </summary>
        /// <returns>Previous position of points centroid.</returns>
        public Vector2 GetPreviousCenterPosition() {
            return getPreviousCenterPosition(Points);
        }

        #endregion
    }
}