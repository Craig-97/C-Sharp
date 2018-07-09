using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class DepthMonitor
    {
        public readonly int maxDepth = 200;

        int depth;

        public DepthMonitor(int maxDepth)
        {
            Contract.Requires(maxDepth > 0);
            Contract.Ensures(this.maxDepth > 0);
            this.maxDepth = maxDepth;
            depth = 0;
        }

        [ContractInvariantMethod]
        private void Invariant()
        {
            Contract.Invariant(depth >= 0);
            Contract.Invariant(depth <= maxDepth);
            Contract.Invariant(maxDepth> 0);
        }

        // Only returns the current depth -> donse't make any visible state changes
        
        public int getCurrentDepth()
        {
            return depth;
        }

        public void set_current_depth(int depth)
        {
            Contract.Requires(depth >= 0);
            Contract.Requires(depth <= this.maxDepth);
            Contract.Ensures(this.depth == depth);
            this.depth = depth;
        }
    }
}
