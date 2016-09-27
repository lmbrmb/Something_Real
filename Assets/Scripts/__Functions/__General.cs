﻿using UnityEngine;

public static class __General
{
    public static Transform FindChildRecursively(Transform parent_object, string child_name)
    {
        Transform result = null;

        for (int i = 0; i < parent_object.childCount; i++)
        {
            Transform current = parent_object.GetChild(i);

            if (current.name == child_name)
            {
                result = current;
            }
            else
            {
                result = FindChildRecursively(current, child_name);
            }

            if (result != null)
            {
                break;
            }
        }

        return result;
    }

    public static GameObject InstantiatePrefab(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent_transform, bool deactivate)
    {
        GameObject instance = UnityEngine.Object.Instantiate(prefab, position, rotation) as GameObject;

        instance.name = prefab.name;

        if (parent_transform!=null)
        {
            instance.transform.SetParent(parent_transform, true);
        }

        if(deactivate)
        {
            instance.SetActive(false);
        }

        return instance;
    }

    public static bool RandomChoice()
    {
        int random_value = UnityEngine.Random.Range(0, 2);

        return random_value > 0;
    }
}