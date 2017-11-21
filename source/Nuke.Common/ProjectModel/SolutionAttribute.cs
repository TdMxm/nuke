﻿// Copyright Matthias Koch 2017.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Core;
using Nuke.Core.Injection;

namespace Nuke.Common.ProjectModel
{
    /// <inheritdoc/>
    [PublicAPI]
    [UsedImplicitly(ImplicitUseKindFlags.Assign)]
    public class SolutionAttribute : StaticInjectionAttributeBase
    {
        [CanBeNull]
        public static string Configuration { get; set; }

        [CanBeNull]
        public static string TargetFramework { get; set; }

        public static Solution Value { get; private set; }

        [CanBeNull]
        public override object GetStaticValue ()
        {
            return Value = Value ??
                           ProjectModelTasks.ParseSolution(
                               NukeBuild.Instance.SolutionFile,
                               Configuration ?? NukeBuild.Instance.Configuration,
                               TargetFramework);
        }
    }
}
