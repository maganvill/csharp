// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ClusterRoleBinding references a ClusterRole, but not contain it.  It
    /// can reference a ClusterRole in the global namespace, and adds who
    /// information via Subject.
    /// </summary>
    public partial class V1ClusterRoleBinding
    {
        /// <summary>
        /// Initializes a new instance of the V1ClusterRoleBinding class.
        /// </summary>
        public V1ClusterRoleBinding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ClusterRoleBinding class.
        /// </summary>
        /// <param name="roleRef">RoleRef can only reference a ClusterRole in
        /// the global namespace. If the RoleRef cannot be resolved, the
        /// Authorizer must return an error.</param>
        /// <param name="subjects">Subjects holds references to the objects the
        /// role applies to.</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata.</param>
        public V1ClusterRoleBinding(V1RoleRef roleRef, IList<V1Subject> subjects, string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            RoleRef = roleRef;
            Subjects = subjects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets roleRef can only reference a ClusterRole in the global
        /// namespace. If the RoleRef cannot be resolved, the Authorizer must
        /// return an error.
        /// </summary>
        [JsonProperty(PropertyName = "roleRef")]
        public V1RoleRef RoleRef { get; set; }

        /// <summary>
        /// Gets or sets subjects holds references to the objects the role
        /// applies to.
        /// </summary>
        [JsonProperty(PropertyName = "subjects")]
        public IList<V1Subject> Subjects { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RoleRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleRef");
            }
            if (Subjects == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subjects");
            }
            if (Metadata != null)
            {
                Metadata.Validate();
            }
            if (RoleRef != null)
            {
                RoleRef.Validate();
            }
            if (Subjects != null)
            {
                foreach (var element in Subjects)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
