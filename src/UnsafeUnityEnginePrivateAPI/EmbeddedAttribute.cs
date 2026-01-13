using System;

namespace Microsoft.CodeAnalysis;

[Embedded]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Struct)]
internal sealed class EmbeddedAttribute : Attribute { }
