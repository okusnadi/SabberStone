﻿using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class BuffTask : SimpleTask
	{
		public BuffTask(Enchant buff, EntityType type, SelfCondition condition = null)
		{
			Buff = buff;
			Type = type;
			Condition = condition;
		}

		public Enchant Buff { get; set; }

		public EntityType Type { get; set; }

		public SelfCondition Condition { get; set; }

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Buff == null)
			{
				return TaskState.STOP;
			}
			var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (Condition != null)
			{
				entities = entities.Where(p => Condition.Eval(p)).ToList();
			}

			entities.ForEach(p => Buff.Activate(source.Card.Id, p.Enchants, p));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new BuffTask(Buff, Type, Condition);
			clone.Copy(this);
			return clone;
		}
	}
}