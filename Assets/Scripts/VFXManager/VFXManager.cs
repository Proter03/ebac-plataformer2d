using Ebac.Core.Singleton;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VFXManager : Singleton<VFXManager>
{
    public enum VFXType
    {
        JUMP,
        VFX_2
    }

    public List<VFXManagerSetup> vfxSetup;

    public void PlayVFXByType(VFXType type, Vector3 position)
    {
        var vfx = vfxSetup.FirstOrDefault(v => v.vfxType.Equals(type));
        if (vfx != null)
        {
            var item = Instantiate(vfx.prefab);
            item.transform.position = position;
            Destroy(item.gameObject, 5f);
        }
    }
}

[System.Serializable]
public class VFXManagerSetup
{
    public VFXManager.VFXType vfxType;
    public GameObject prefab;
}