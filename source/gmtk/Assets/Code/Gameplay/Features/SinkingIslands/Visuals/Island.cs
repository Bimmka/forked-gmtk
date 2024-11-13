using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.SinkingIslands.Visuals
{
    public class Island : MonoBehaviour
    {
        public Tilemap Tilemap;

        [ContextMenu("Test")]
        public void Test()
        {
            ChangeScale(Vector3.zero);
        }

        public void ChangeScale(Vector3 worldPosition)
        {
            var cellPosition = Tilemap.WorldToCell(worldPosition);
            Tile tile = Tilemap.GetTile<Tile>(cellPosition);

            var tileTransform = tile.transform;
            var scale = ExtractScaleFromMatrix(ref tileTransform);
            tileTransform.m00 = 5f;
            tileTransform.m11 = 5f;
            tileTransform.m22 = 5f;

            tile.transform = tileTransform;

            tile.transform.SetTRS(worldPosition, Quaternion.identity, new Vector3(50,50,50));
            
            Matrix4x4 newMatrix = Matrix4x4.Scale(new Vector3(5, 5, 5));

            Tilemap.SetTileFlags(cellPosition, TileFlags.None);
            Tilemap.SetTransformMatrix(cellPosition, newMatrix);
        }
        
        public static Vector3 ExtractScaleFromMatrix(ref Matrix4x4 matrix) {
            Vector3 scale;
            scale.x = new Vector4(matrix.m00, matrix.m10, matrix.m20, matrix.m30).magnitude;
            scale.y = new Vector4(matrix.m01, matrix.m11, matrix.m21, matrix.m31).magnitude;
            scale.z = new Vector4(matrix.m02, matrix.m12, matrix.m22, matrix.m32).magnitude;
            return scale;
        }
    }
}