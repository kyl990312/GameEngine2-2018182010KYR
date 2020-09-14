using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class EventManager : SingletonBehaviour<EventManager>
    {
        private IDictionary<string, List<Action<object>>> _eventDatabase;

        private void Awake()
        {
            _eventDatabase = new Dictionary<string, List<Action<object>>>();
        }

        public static void On(string eventName, Action<object> subscriberAction)
        {
            if (!Instance._eventDatabase.ContainsKey(eventName))
            {
                Instance._eventDatabase.Add(eventName, new List<Action<object>>());
            }
            Instance._eventDatabase[eventName].Add(subscriberAction);
        }
        
        public static void Emit(string eventName, object parameter)
        {
            if (!Instance._eventDatabase.ContainsKey(eventName))
            {
                Debug.LogWarning("EventName doesn't exist");
                return;
            }

            foreach (var action in Instance._eventDatabase[eventName] )
            {
                action.Invoke(parameter);
            }
        }
    }
}

