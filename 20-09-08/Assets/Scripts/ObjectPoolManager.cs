using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = System.Object;

namespace Script
{
    public class ObjectPoolManager : SingletonBehaviour<ObjectPoolManager>
    {
        [Serializable]
        public class ObjectPoolData
        {
            public string name;
            public GameObject prefab;
        }

        public List<ObjectPoolData> prefabs;

        private IDictionary<string, List<GameObject>> _dataPool;

        private void Awake()
        {
            _dataPool = new Dictionary<string, List<GameObject>>();
        }
        public GameObject Spawn(string spawnTargetName)
        {
            var foundedPrefab = prefabs.FirstOrDefault(prefab => prefab.name == spawnTargetName);
            if(foundedPrefab == null)throw new Exception($"{spawnTargetName} doesn't exist");

            if (!_dataPool.ContainsKey((spawnTargetName)))
            {
                _dataPool.Add(spawnTargetName, new List<GameObject>());
            }

           var founded = _dataPool[spawnTargetName].FirstOrDefault(poolItem => !poolItem.activeInHierarchy);
           if (founded == null)
           {
               founded = Instantiate(foundedPrefab.prefab);
               _dataPool[spawnTargetName].Add(founded);
           }
           founded.SetActive(true);
            return founded;
        }
    }  
}

