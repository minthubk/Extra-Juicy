//Zenith Code 2014
using UnityEditor;

[CustomEditor(typeof(VFXSorter))]
public class VFXSorterEditor : Editor
{
    private VFXSorter _vfx;
    private int _index;

    private void OnEnable()
    {
        _vfx = (VFXSorter)target;
        //Get current layer
        for (int i = 0; i < _vfx.sortingLayers.Length; i++)
        {
            if (_vfx.sortingLayers[i] == _vfx.sortingLayer)
            {
                _index = i;
            }
        }
    }


    public override void OnInspectorGUI()
    {
        //Sorting layer
        _index = EditorGUILayout.Popup("Sorting layers", _index, _vfx.sortingLayers);
        _vfx.sortingLayer = _vfx.sortingLayers[_index];
        
        //Sorting order
        _vfx.sortingOrder = EditorGUILayout.IntField("Sort Order", _vfx.sortingOrder);
    }
}
