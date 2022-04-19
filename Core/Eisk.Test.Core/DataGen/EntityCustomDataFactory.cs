using System;

namespace Eisk.Test.Core.DataGen
{
    public abstract class EntityCustomDataFactory<TEntity> :EntityDataFactory<TEntity>
    {
        public override TEntity Factory_Entity(Action<TEntity>? action = null)
        {
            var employee = base.Factory_Entity(e =>
            {
                AssignEntity(e);

                //supporting custom overrides from user
                action?.Invoke(e);
            });

            return employee;
        }

        protected abstract void AssignEntity(TEntity e);
    }
}
