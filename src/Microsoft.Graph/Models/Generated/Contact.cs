// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Contact.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Contact : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The ID of the contact's parent folder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "birthday", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets file as.
        /// The name the contact is filed under.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileAs", Required = Newtonsoft.Json.Required.Default)]
        public string FileAs { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The contact's given name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "givenName", Required = Newtonsoft.Json.Required.Default)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets initials.
        /// The contact's initials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initials", Required = Newtonsoft.Json.Required.Default)]
        public string Initials { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// The contact's middle name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "middleName", Required = Newtonsoft.Json.Required.Default)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets nick name.
        /// The contact's nickname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nickName", Required = Newtonsoft.Json.Required.Default)]
        public string NickName { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The contact's surname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "surname", Required = Newtonsoft.Json.Required.Default)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The contact's title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets yomi given name.
        /// The phonetic Japanese given name (first name) of the contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiGivenName", Required = Newtonsoft.Json.Required.Default)]
        public string YomiGivenName { get; set; }
    
        /// <summary>
        /// Gets or sets yomi surname.
        /// The phonetic Japanese surname (last name)  of the contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiSurname", Required = Newtonsoft.Json.Required.Default)]
        public string YomiSurname { get; set; }
    
        /// <summary>
        /// Gets or sets yomi company name.
        /// The phonetic Japanese company name of the contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiCompanyName", Required = Newtonsoft.Json.Required.Default)]
        public string YomiCompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets generation.
        /// The contact's generation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "generation", Required = Newtonsoft.Json.Required.Default)]
        public string Generation { get; set; }
    
        /// <summary>
        /// Gets or sets email addresses.
        /// The contact's email addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<TypedEmailAddress> EmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets websites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "websites", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Website> Websites { get; set; }
    
        /// <summary>
        /// Gets or sets im addresses.
        /// The contact's instant messaging (IM) addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ImAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// The contact’s job title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobTitle", Required = Newtonsoft.Json.Required.Default)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// The name of the contact's company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyName", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The contact's department.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "department", Required = Newtonsoft.Json.Required.Default)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// The location of the contact's office.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeLocation", Required = Newtonsoft.Json.Required.Default)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets profession.
        /// The contact's profession.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profession", Required = Newtonsoft.Json.Required.Default)]
        public string Profession { get; set; }
    
        /// <summary>
        /// Gets or sets assistant name.
        /// The name of the contact's assistant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assistantName", Required = Newtonsoft.Json.Required.Default)]
        public string AssistantName { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// The name of the contact's manager.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manager", Required = Newtonsoft.Json.Required.Default)]
        public string Manager { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Phone> Phones { get; set; }
    
        /// <summary>
        /// Gets or sets postal addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PhysicalAddress> PostalAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets spouse name.
        /// The name of the contact's spouse/partner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "spouseName", Required = Newtonsoft.Json.Required.Default)]
        public string SpouseName { get; set; }
    
        /// <summary>
        /// Gets or sets personal notes.
        /// The user's notes about the contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "personalNotes", Required = Newtonsoft.Json.Required.Default)]
        public string PersonalNotes { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// The names of the contact's children.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "children", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Children { get; set; }
    
        /// <summary>
        /// Gets or sets wedding anniversary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "weddingAnniversary", Required = Newtonsoft.Json.Required.Default)]
        public Date WeddingAnniversary { get; set; }
    
        /// <summary>
        /// Gets or sets gender.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gender", Required = Newtonsoft.Json.Required.Default)]
        public string Gender { get; set; }
    
        /// <summary>
        /// Gets or sets is favorite.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFavorite", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFavorite { get; set; }
    
        /// <summary>
        /// Gets or sets flag.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flag", Required = Newtonsoft.Json.Required.Default)]
        public FollowupFlag Flag { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the contact. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IContactExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the contact. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IContactSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IContactMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// Optional contact picture. You can get or set a photo for a contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photo", Required = Newtonsoft.Json.Required.Default)]
        public ProfilePhoto Photo { get; set; }
    
    }
}

