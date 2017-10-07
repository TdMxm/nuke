// Copyright Matthias Koch 2017.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Common.ProjectModel
{
    [PublicAPI]
    public class Solution
    {
        internal Solution (string path, IReadOnlyCollection<Project> projects)
        {
            Path = path;
            Projects = projects;
        }

        public string Path { get; }
        public IReadOnlyCollection<Project> Projects { get; }

        public static implicit operator string (Solution solution)
        {
            return solution.Path;
        }
    }
}
