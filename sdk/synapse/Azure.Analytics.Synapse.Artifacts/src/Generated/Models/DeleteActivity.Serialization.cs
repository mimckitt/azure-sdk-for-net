// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DeleteActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LinkedServiceName != null)
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Policy != null)
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (DependsOn != null)
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (UserProperties != null)
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Recursive != null)
            {
                writer.WritePropertyName("recursive");
                writer.WriteObjectValue(Recursive);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteNumberValue(MaxConcurrentConnections.Value);
            }
            if (EnableLogging != null)
            {
                writer.WritePropertyName("enableLogging");
                writer.WriteObjectValue(EnableLogging);
            }
            if (LogStorageSettings != null)
            {
                writer.WritePropertyName("logStorageSettings");
                writer.WriteObjectValue(LogStorageSettings);
            }
            writer.WritePropertyName("dataset");
            writer.WriteObjectValue(Dataset);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeleteActivity DeserializeDeleteActivity(JsonElement element)
        {
            LinkedServiceReference linkedServiceName = default;
            ActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            IList<ActivityDependency> dependsOn = default;
            IList<UserProperty> userProperties = default;
            object recursive = default;
            int? maxConcurrentConnections = default;
            object enableLogging = default;
            LogStorageSettings logStorageSettings = default;
            DatasetReference dataset = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ActivityDependency.DeserializeActivityDependency(item));
                        }
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(UserProperty.DeserializeUserProperty(item));
                        }
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recursive"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recursive = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrentConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxConcurrentConnections = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableLogging"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableLogging = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("logStorageSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logStorageSettings = LogStorageSettings.DeserializeLogStorageSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataset"))
                        {
                            dataset = DatasetReference.DeserializeDatasetReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DeleteActivity(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy, recursive, maxConcurrentConnections, enableLogging, logStorageSettings, dataset);
        }
    }
}
