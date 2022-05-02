using System;

namespace crosscutting.sql
{
    using System;

    /// <summary>
    /// Defines the <see cref="IDbEntity" />
    /// </summary>
    public interface IDbEntity
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        Guid Id { get; set; }
    }

    public interface ISummaryDbEntity
    {
        string Basic { get; }
        string Extended { get; }
        string Detailed { get; }
    }
}

namespace crosscutting.sql
{
    /// <summary>
    /// Defines the <see cref="IDbRecord" />
    /// </summary>
    public interface IDbRecord
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        long Id { get; set; }
    }

    public interface ITopLevelDbEntity : IDbEntity
    {
        long Revision { get; set; }
    }

}


namespace crosscutting.cqrs
{
    public interface IEntityCreationDateTime
    {
        DateTime UtcNow { get; }
    }

    public interface IEntityCreationContext
    {
        IEntityCreationDateTime DateTime { get; }
    }

    public class DefaultEntityCreationDateTime : IEntityCreationDateTime
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
    class DefaultEntityCreationContext : IEntityCreationContext
    {
        public IEntityCreationDateTime DateTime { get; } = new DefaultEntityCreationDateTime();
    }

    public static class EntityCreationContext
    {
        public static IEntityCreationContext Default { get; set; } = new DefaultEntityCreationContext();

        public static IEntityCreationContext SQL => Default;
    }
}

namespace crosscutting.Attributes
{
    using System;

    /// <summary>
    /// Defines the <see cref="LabelAttribute" />
    /// </summary>
    public class LabelAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public string Value { get; set; }
        public string Note { get; set; }
        public string Hint { get; set; }
    }
}
