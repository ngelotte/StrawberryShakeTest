// RainOnePersonEntity.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RainOnePersonEntity
    {
        public RainOnePersonEntity(
            global::System.String displayName,
            global::System.Int32 id,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> rainOnePersonLinks,
            global::System.String primaryEmailAddress)
        {
            DisplayName = displayName;
            Id = id;
            RainOnePersonLinks = rainOnePersonLinks;
            PrimaryEmailAddress = primaryEmailAddress;
        }

        public global::System.String DisplayName { get; }

        public global::System.Int32 Id { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> RainOnePersonLinks { get; }

        public global::System.String PrimaryEmailAddress { get; }
    }
}


// RainOnePersonLinkEntity.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RainOnePersonLinkEntity
    {
        public RainOnePersonLinkEntity(
            global::System.String displayName,
            global::System.String emailAddress,
            global::RainOneClient.GraphQL.PersonLinkType personLinkType,
            global::System.Int32 rainOnePersonId)
        {
            DisplayName = displayName;
            EmailAddress = emailAddress;
            PersonLinkType = personLinkType;
            RainOnePersonId = rainOnePersonId;
        }

        public global::System.String DisplayName { get; }

        public global::System.String EmailAddress { get; }

        public global::RainOneClient.GraphQL.PersonLinkType PersonLinkType { get; }

        public global::System.Int32 RainOnePersonId { get; }
    }
}


// GetPeopleResultFactory.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeopleResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::RainOneClient.GraphQL.GetPeopleResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonEntity, GetPeople_RainOnePeople_RainOnePerson> _getPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper;

        public GetPeopleResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonEntity, GetPeople_RainOnePeople_RainOnePerson> getPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper = getPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::RainOneClient.GraphQL.IGetPeopleResult);

        public GetPeopleResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetPeopleResultInfo info)
            {
                return new GetPeopleResult(MapNonNullableIGetPeople_RainOnePeopleNonNullableArray(
                    info.RainOnePeople,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetPeopleResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople> MapNonNullableIGetPeople_RainOnePeopleNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var rainOnePersons = new global::System.Collections.Generic.List<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                rainOnePersons.Add(MapNonNullableIGetPeople_RainOnePeople(
                    child,
                    snapshot));
            }

            return rainOnePersons;
        }

        private global::RainOneClient.GraphQL.IGetPeople_RainOnePeople MapNonNullableIGetPeople_RainOnePeople(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "RainOnePerson",
                    global::System.StringComparison.Ordinal))
            {
                return _getPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper.Map(
                    snapshot.GetEntity<global::RainOneClient.GraphQL.State.RainOnePersonEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetPeopleResultInfo.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeopleResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetPeopleResultInfo(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> rainOnePeople,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            RainOnePeople = rainOnePeople;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> RainOnePeople { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetPeopleResultInfo(
                RainOnePeople,
                _entityIds,
                version);
        }
    }
}


// GetPeopleResult.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeopleResult
        : global::System.IEquatable<GetPeopleResult>
        , IGetPeopleResult
    {
        public GetPeopleResult(global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople> rainOnePeople)
        {
            RainOnePeople = rainOnePeople;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople> RainOnePeople { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetPeopleResult)obj);
        }

        public global::System.Boolean Equals(GetPeopleResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        RainOnePeople,
                        other.RainOnePeople));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                foreach (var RainOnePeople_elm in RainOnePeople)
                {
                    hash ^= 397 * RainOnePeople_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper
        : global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonEntity, GetPeople_RainOnePeople_RainOnePerson>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity, GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink> _getPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper;

        public GetPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity, GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink> getPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper = getPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper));
        }

        public GetPeople_RainOnePeople_RainOnePerson Map(
            global::RainOneClient.GraphQL.State.RainOnePersonEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetPeople_RainOnePeople_RainOnePerson(
                entity.DisplayName,
                entity.Id,
                MapNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksNonNullableArray(
                    entity.RainOnePersonLinks,
                    snapshot),
                entity.PrimaryEmailAddress);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople_RainOnePersonLinks> MapNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var rainOnePersonLinks = new global::System.Collections.Generic.List<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople_RainOnePersonLinks>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                rainOnePersonLinks.Add(MapNonNullableIGetPeople_RainOnePeople_RainOnePersonLinks(
                    child,
                    snapshot));
            }

            return rainOnePersonLinks;
        }

        private global::RainOneClient.GraphQL.IGetPeople_RainOnePeople_RainOnePersonLinks MapNonNullableIGetPeople_RainOnePeople_RainOnePersonLinks(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "RainOnePersonLink",
                    global::System.StringComparison.Ordinal))
            {
                return _getPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper.Map(
                    snapshot.GetEntity<global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetPeople_RainOnePeople_RainOnePerson.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeople_RainOnePeople_RainOnePerson
        : global::System.IEquatable<GetPeople_RainOnePeople_RainOnePerson>
        , IGetPeople_RainOnePeople_RainOnePerson
    {
        public GetPeople_RainOnePeople_RainOnePerson(
            global::System.String displayName,
            global::System.Int32 id,
            global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople_RainOnePersonLinks> rainOnePersonLinks,
            global::System.String primaryEmailAddress)
        {
            DisplayName = displayName;
            Id = id;
            RainOnePersonLinks = rainOnePersonLinks;
            PrimaryEmailAddress = primaryEmailAddress;
        }

        public global::System.String DisplayName { get; }

        public global::System.Int32 Id { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople_RainOnePersonLinks> RainOnePersonLinks { get; }

        public global::System.String PrimaryEmailAddress { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetPeople_RainOnePeople_RainOnePerson)obj);
        }

        public global::System.Boolean Equals(GetPeople_RainOnePeople_RainOnePerson? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (DisplayName.Equals(other.DisplayName))
                && Id == other.Id
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        RainOnePersonLinks,
                        other.RainOnePersonLinks)
                && PrimaryEmailAddress.Equals(other.PrimaryEmailAddress);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * DisplayName.GetHashCode();

                hash ^= 397 * Id.GetHashCode();

                foreach (var RainOnePersonLinks_elm in RainOnePersonLinks)
                {
                    hash ^= 397 * RainOnePersonLinks_elm.GetHashCode();
                }

                hash ^= 397 * PrimaryEmailAddress.GetHashCode();

                return hash;
            }
        }
    }
}


// GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper
        : global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity, GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink>
    {
        public GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink Map(
            global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink(
                entity.DisplayName,
                entity.EmailAddress,
                entity.PersonLinkType,
                entity.RainOnePersonId);
        }
    }
}


// GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink
        : global::System.IEquatable<GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink>
        , IGetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink
    {
        public GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink(
            global::System.String displayName,
            global::System.String emailAddress,
            global::RainOneClient.GraphQL.PersonLinkType personLinkType,
            global::System.Int32 rainOnePersonId)
        {
            DisplayName = displayName;
            EmailAddress = emailAddress;
            PersonLinkType = personLinkType;
            RainOnePersonId = rainOnePersonId;
        }

        public global::System.String DisplayName { get; }

        public global::System.String EmailAddress { get; }

        public global::RainOneClient.GraphQL.PersonLinkType PersonLinkType { get; }

        public global::System.Int32 RainOnePersonId { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink)obj);
        }

        public global::System.Boolean Equals(GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (DisplayName.Equals(other.DisplayName))
                && EmailAddress.Equals(other.EmailAddress)
                && PersonLinkType.Equals(other.PersonLinkType)
                && RainOnePersonId == other.RainOnePersonId;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * DisplayName.GetHashCode();

                hash ^= 397 * EmailAddress.GetHashCode();

                hash ^= 397 * PersonLinkType.GetHashCode();

                hash ^= 397 * RainOnePersonId.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetPeopleResult.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetPeopleResult
    {
        public global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople> RainOnePeople { get; }
    }
}


// IGetPeople_RainOnePeople.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetPeople_RainOnePeople
    {
        public global::System.String DisplayName { get; }

        public global::System.Int32 Id { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::RainOneClient.GraphQL.IGetPeople_RainOnePeople_RainOnePersonLinks> RainOnePersonLinks { get; }

        public global::System.String PrimaryEmailAddress { get; }
    }
}


// IGetPeople_RainOnePeople_RainOnePerson.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetPeople_RainOnePeople_RainOnePerson
        : IGetPeople_RainOnePeople
    {
    }
}


// IGetPeople_RainOnePeople_RainOnePersonLinks.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetPeople_RainOnePeople_RainOnePersonLinks
    {
        public global::System.String DisplayName { get; }

        public global::System.String EmailAddress { get; }

        public global::RainOneClient.GraphQL.PersonLinkType PersonLinkType { get; }

        public global::System.Int32 RainOnePersonId { get; }
    }
}


// IGetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink
        : IGetPeople_RainOnePeople_RainOnePersonLinks
    {
    }
}


// PersonLinkType.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public enum PersonLinkType
    {
        B2cuniqueid,
        Finops,
        Tracker
    }
}


// PersonLinkTypeSerializer.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class PersonLinkTypeSerializer
        : global::StrawberryShake.Serialization.IInputValueFormatter
        , global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, PersonLinkType>
    {
        public global::System.String TypeName => "PersonLinkType";

        public PersonLinkType Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
                "B2CUNIQUEID" => PersonLinkType.B2cuniqueid,
                "FINOPS" => PersonLinkType.Finops,
                "TRACKER" => PersonLinkType.Tracker,
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
                PersonLinkType.B2cuniqueid => "B2CUNIQUEID",
                PersonLinkType.Finops => "FINOPS",
                PersonLinkType.Tracker => "TRACKER",
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }
    }
}


// GetPeopleQueryDocument.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    /// <summary>
    /// Represents the operation service of the GetPeople GraphQL operation
    /// <code>
    /// query GetPeople {
    ///   rainOnePeople {
    ///     __typename
    ///     displayName
    ///     id
    ///     rainOnePersonLinks {
    ///       __typename
    ///       displayName
    ///       emailAddress
    ///       personLinkType
    ///       rainOnePersonId
    ///       ... on RainOnePersonLink {
    ///         id
    ///       }
    ///     }
    ///     primaryEmailAddress
    ///     ... on RainOnePerson {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeopleQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetPeopleQueryDocument()
        {
        }

        public static GetPeopleQueryDocument Instance { get; } = new GetPeopleQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x50, 0x65, 0x6f, 0x70, 0x6c, 0x65, 0x20, 0x7b, 0x20, 0x72, 0x61, 0x69, 0x6e, 0x4f, 0x6e, 0x65, 0x50, 0x65, 0x6f, 0x70, 0x6c, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x64, 0x69, 0x73, 0x70, 0x6c, 0x61, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x64, 0x20, 0x72, 0x61, 0x69, 0x6e, 0x4f, 0x6e, 0x65, 0x50, 0x65, 0x72, 0x73, 0x6f, 0x6e, 0x4c, 0x69, 0x6e, 0x6b, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x64, 0x69, 0x73, 0x70, 0x6c, 0x61, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x65, 0x6d, 0x61, 0x69, 0x6c, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x70, 0x65, 0x72, 0x73, 0x6f, 0x6e, 0x4c, 0x69, 0x6e, 0x6b, 0x54, 0x79, 0x70, 0x65, 0x20, 0x72, 0x61, 0x69, 0x6e, 0x4f, 0x6e, 0x65, 0x50, 0x65, 0x72, 0x73, 0x6f, 0x6e, 0x49, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x69, 0x6e, 0x4f, 0x6e, 0x65, 0x50, 0x65, 0x72, 0x73, 0x6f, 0x6e, 0x4c, 0x69, 0x6e, 0x6b, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x70, 0x72, 0x69, 0x6d, 0x61, 0x72, 0x79, 0x45, 0x6d, 0x61, 0x69, 0x6c, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x69, 0x6e, 0x4f, 0x6e, 0x65, 0x50, 0x65, 0x72, 0x73, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "0355c73fb5e5e31dab72aaaed05c345bf43a340b");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetPeopleQuery.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    /// <summary>
    /// Represents the operation service of the GetPeople GraphQL operation
    /// <code>
    /// query GetPeople {
    ///   rainOnePeople {
    ///     __typename
    ///     displayName
    ///     id
    ///     rainOnePersonLinks {
    ///       __typename
    ///       displayName
    ///       emailAddress
    ///       personLinkType
    ///       rainOnePersonId
    ///       ... on RainOnePersonLink {
    ///         id
    ///       }
    ///     }
    ///     primaryEmailAddress
    ///     ... on RainOnePerson {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeopleQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetPeopleResult> _operationExecutor;

        public GetPeopleQuery(global::StrawberryShake.IOperationExecutor<IGetPeopleResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetPeopleResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetPeopleResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetPeopleResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetPeopleQueryDocument.Instance.Hash.Value,
                name: "GetPeople",
                document: GetPeopleQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }
}


// GetPeopleBuilder.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetPeopleBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::RainOneClient.GraphQL.IGetPeopleResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::RainOneClient.GraphQL.IGetPeopleResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::RainOneClient.GraphQL.PersonLinkType> _personLinkTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;

        public GetPeopleBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::RainOneClient.GraphQL.IGetPeopleResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _personLinkTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::RainOneClient.GraphQL.PersonLinkType>("PersonLinkType")
                 ?? throw new global::System.ArgumentException("No serializer for type `PersonLinkType` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetPeopleResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetPeopleResult Result, GetPeopleResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetPeopleResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetPeopleResult, GetPeopleResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> rainOnePeopleId = default!;
            _entityStore.Update(session => 
            {
                rainOnePeopleId = UpdateNonNullableIGetPeople_RainOnePeopleEntityNonNullableArray(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "rainOnePeople"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetPeopleResultInfo(
                rainOnePeopleId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetPeople_RainOnePeopleEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var rainOnePersons = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                rainOnePersons.Add(UpdateNonNullableIGetPeople_RainOnePeopleEntity(
                    session,
                    child,
                    entityIds));
            }

            return rainOnePersons;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetPeople_RainOnePeopleEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "RainOnePerson",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::RainOneClient.GraphQL.State.RainOnePersonEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::RainOneClient.GraphQL.State.RainOnePersonEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "displayName")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            UpdateNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rainOnePersonLinks"),
                                entityIds),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "primaryEmailAddress"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::RainOneClient.GraphQL.State.RainOnePersonEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "displayName")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            UpdateNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rainOnePersonLinks"),
                                entityIds),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "primaryEmailAddress"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var rainOnePersonLinks = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                rainOnePersonLinks.Add(UpdateNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksEntity(
                    session,
                    child,
                    entityIds));
            }

            return rainOnePersonLinks;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetPeople_RainOnePeople_RainOnePersonLinksEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "RainOnePersonLink",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "displayName")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "emailAddress")),
                            DeserializeNonNullablePersonLinkType(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "personLinkType")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rainOnePersonId"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "displayName")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "emailAddress")),
                            DeserializeNonNullablePersonLinkType(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "personLinkType")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rainOnePersonId"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::RainOneClient.GraphQL.PersonLinkType DeserializeNonNullablePersonLinkType(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _personLinkTypeParser.Parse(obj.Value.GetString()!);
        }
    }
}


// GraphQlClient.cs
#nullable enable

namespace RainOneClient.GraphQL
{
    /// <summary>
    /// Represents the GraphQlClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GraphQlClient
    {
        private readonly global::RainOneClient.GraphQL.GetPeopleQuery _getPeople;

        public GraphQlClient(global::RainOneClient.GraphQL.GetPeopleQuery getPeople)
        {
            _getPeople = getPeople
                 ?? throw new global::System.ArgumentNullException(nameof(getPeople));
        }

        public static global::System.String ClientName => "GraphQlClient";

        public global::RainOneClient.GraphQL.GetPeopleQuery GetPeople => _getPeople;
    }
}


// GraphQlClientEntityIdFactory.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GraphQlClientEntityIdFactory
        : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions(){ Indented = false };

        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String typeName = obj
                .GetProperty("__typename")
                .GetString()!;

            return typeName switch
            {
                "RainOnePerson" => ParseRainOnePersonEntityId(
                    obj,
                    typeName),
                "RainOnePersonLink" => ParseRainOnePersonLinkEntityId(
                    obj,
                    typeName),
                _ => throw new global::System.NotSupportedException()
            };
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "RainOnePerson" => FormatRainOnePersonEntityId(entityId),
                "RainOnePersonLink" => FormatRainOnePersonLinkEntityId(entityId),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private global::StrawberryShake.EntityId ParseRainOnePersonEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetInt32()!);
        }

        private global::System.String FormatRainOnePersonEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteNumber(
                "id",
                (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseRainOnePersonLinkEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetInt32()!);
        }

        private global::System.String FormatRainOnePersonLinkEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteNumber(
                "id",
                (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }
    }
}


// GraphQlClientServiceCollectionExtensions.cs
#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public static partial class GraphQlClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::RainOneClient.GraphQL.State.GraphQlClientStoreAccessor> AddGraphQlClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = ConfigureClientDefault(
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new global::RainOneClient.GraphQL.State.GraphQlClientStoreAccessor(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::RainOneClient.GraphQL.GetPeopleQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::RainOneClient.GraphQL.GraphQlClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return new global::StrawberryShake.ClientBuilder<global::RainOneClient.GraphQL.State.GraphQlClientStoreAccessor>(
                "GraphQlClient",
                services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("GraphQlClient"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonEntity, global::RainOneClient.GraphQL.GetPeople_RainOnePeople_RainOnePerson>, global::RainOneClient.GraphQL.State.GetPeople_RainOnePeople_RainOnePersonFromRainOnePersonEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::RainOneClient.GraphQL.State.RainOnePersonLinkEntity, global::RainOneClient.GraphQL.GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLink>, global::RainOneClient.GraphQL.State.GetPeople_RainOnePeople_RainOnePersonLinks_RainOnePersonLinkFromRainOnePersonLinkEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::RainOneClient.GraphQL.PersonLinkTypeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::RainOneClient.GraphQL.IGetPeopleResult>, global::RainOneClient.GraphQL.State.GetPeopleResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::RainOneClient.GraphQL.IGetPeopleResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::RainOneClient.GraphQL.GetPeopleQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::RainOneClient.GraphQL.IGetPeopleResult>, global::RainOneClient.GraphQL.State.GetPeopleBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::RainOneClient.GraphQL.IGetPeopleResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::RainOneClient.GraphQL.IGetPeopleResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::RainOneClient.GraphQL.IGetPeopleResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::RainOneClient.GraphQL.GetPeopleQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::RainOneClient.GraphQL.State.GraphQlClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::RainOneClient.GraphQL.GraphQlClient>(services);
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


// GraphQlClientStoreAccessor.cs
#nullable enable

namespace RainOneClient.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GraphQlClientStoreAccessor
        : global::StrawberryShake.StoreAccessor
    {
        public GraphQlClientStoreAccessor(
            global::StrawberryShake.IOperationStore operationStore,
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer entityIdSerializer,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories)
            : base(
                operationStore,
                entityStore,
                entityIdSerializer,
                requestFactories,
                resultDataFactories)
        {
        }
    }
}


