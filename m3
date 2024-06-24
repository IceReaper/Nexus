// General 16 byte padding.
struct Padding
{
    SetBackColor(cBlack);
    ubyte padding[(16 - FTell() % 16) % 16];
};

// M3 chunks
struct Unk0
{
    ubyte unk[112]; // TODO parse me!
    Padding padding;
};

struct Unk14
{
    ushort unk1; // TODO
    short unk2; // TODO
    
    if (unk2 == -1)
        ubyte unk[188]; // TODO parse me!
    else
        ubyte unk[204]; // TODO parse me!

    Padding padding;
};

struct Bone
{
    ushort id;
    ushort unk1; // flags?
    ushort parent;
    ushort unk2; // mesh?
    ubyte rotation_11;
    ubyte rotation_13;
    ubyte rotation_31;
    ubyte rotation_33;
    byte unk3[4];

    uint64 animation1Entries;
    uint64 animation1TimeOffset;
    uint64 animation1ValueOffset;
    uint64 animation2Entries;
    uint64 animation2TimeOffset;
    uint64 animation2ValueOffset;
    uint64 animation3Entries;
    uint64 animation3TimeOffset;
    uint64 animation3ValueOffset;
    uint64 animation4Entries;
    uint64 animation4TimeOffset;
    uint64 animation4ValueOffset;
    uint64 animation5Entries;
    uint64 animation5TimeOffset;
    uint64 animation5ValueOffset;
    uint64 animation6Entries;
    uint64 animation6TimeOffset;
    uint64 animation6ValueOffset;
    uint64 animation7Entries;
    uint64 animation7TimeOffset;
    uint64 animation7ValueOffset;
    uint64 animation8Entries;
    uint64 animation8TimeOffset;
    uint64 animation8ValueOffset;

    float transform_11;
    float transform_12;
    float transform_13;
    float transform_14;
    float transform_21;
    float transform_22;
    float transform_23;
    float transform_24;
    float transform_31;
    float transform_32;
    float transform_33;
    float transform_34;
    float transform_41;
    float transform_42;
    float transform_43;
    float transform_44;
    
    float inverseTransform_11;
    float inverseTransform_12;
    float inverseTransform_13;
    float inverseTransform_14;
    float inverseTransform_21;
    float inverseTransform_22;
    float inverseTransform_23;
    float inverseTransform_24;
    float inverseTransform_31;
    float inverseTransform_32;
    float inverseTransform_33;
    float inverseTransform_34;
    float inverseTransform_41;
    float inverseTransform_42;
    float inverseTransform_43;
    float inverseTransform_44;
    
    float originX;
    float originY;
    float originZ;
    
    Padding padding;
};

struct BoneAnimations(Bone &bone)
{
    if (bone.animation1Entries > 0)
    {
        uint unk1a[bone.animation1Entries];
        Padding padding;
        byte unk1b[bone.animation1Entries * 6];
        Padding padding;
    }

    if (bone.animation5Entries > 0)
    {
        uint unk5a[bone.animation5Entries];
        Padding padding;
        byte unk5[bone.animation5Entries * 8];
        Padding padding;
    }

    if (bone.animation7Entries > 0)
    {
        uint unk7a[bone.animation7Entries];
        Padding padding;
        byte unk7[bone.animation7Entries * 12];
        Padding padding;
    }
};

struct Unk26(uint count)
{
    ushort unk[count]; // TODO parse me!

    Padding padding;
};

// Texture start
struct Texture
{
    ushort unk1; // TODO
    ushort unk2; // TODO
    uint unk3; // TODO
    ushort unk4; // TODO
    ushort unk5; // TODO
    uint unk6; // TODO
    uint64 fileNameLength;
    uint64 fileNameOffset;
    Padding padding;
};

struct TexturePath
{
    wstring text;
    Padding padding;
};
// Texture end

// Material start
struct MaterialHeader
{
    uint unk1; // TODO
    uint unk2; // TODO
    uint unk3; // TODO
    uint unk4; // TODO
    uint unk5; // TODO
    uint unk6; // TODO
    uint unk7; // TODO
    uint unk8; // TODO
    uint64 layers; // TODO
    uint64 layersOffset;
    Padding padding;
};

struct MaterialLayerChunk
{
    uint64 present;
    uint64 firstValue;
    uint64 lastValue;
};

struct MaterialLayerHeader
{
    ushort texture1;
    ushort texture2;
    uint unk1; // TODO
    uint unk2; // TODO
    uint unk3; // TODO
    uint unk4; // TODO
    uint unk5; // TODO

    MaterialLayerChunk chunk[11];

    uint unk6; // TODO
    uint unk7; // TODO
};

struct MaterialLayerData(MaterialLayerHeader &header)
{
    // TODO length calculation might be wrong!
    if (header.chunk[0].present == 1)
    {
        byte unk8_0[(header.chunk[0].lastValue - header.chunk[0].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[1].present == 1)
    {
        byte unk8_1[(header.chunk[1].lastValue - header.chunk[1].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[2].present == 1)
    {
        byte unk8_2[(header.chunk[2].lastValue - header.chunk[2].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[3].present == 1)
    {
        byte unk8_3[(header.chunk[3].lastValue - header.chunk[3].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[4].present == 1)
    {
        byte unk8_4[(header.chunk[4].lastValue - header.chunk[4].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[5].present == 1)
    {
        byte unk8_5[(header.chunk[5].lastValue - header.chunk[5].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[6].present == 1)
    {
        byte unk8_6[(header.chunk[6].lastValue - header.chunk[6].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[7].present == 1)
    {
        byte unk8_7[(header.chunk[7].lastValue - header.chunk[7].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[8].present == 1)
    {
        byte unk8_8[(header.chunk[8].lastValue - header.chunk[8].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[9].present == 1)
    {
        byte unk8_9[(header.chunk[9].lastValue - header.chunk[9].firstValue) * 2]; // TODO
        Padding padding;
    }

    if (header.chunk[10].present == 1)
    {
        byte unk8_10[(header.chunk[10].lastValue - header.chunk[10].firstValue) * 2]; // TODO
        Padding padding;
    }
};

struct MaterialLayers(uint layersCount)
{
    MaterialLayerHeader layerHeaders[layersCount]<optimize=false>;
    
    local int i;
    for (i = 0; i < layersCount; i++)
        MaterialLayerData layerDatas(layerHeaders[i]);
    
    Padding padding;
};
// Material end

// Geometry start
struct Vector3(byte type)
{
    if (type == 1)
    {
        float x;
        float y;
        float z;
    }
    else if (type == 2)
    {
        short x;
        short y;
        short z;
    }
    else if (type == 3)
    {
        byte x;
        byte y;
        // z is likely sqrt(x*x+y*y)
    }
    else
        Assert(false);
};

struct Vector4(byte type)
{
    if (type == 4)
    {
        byte x;
        byte y;
        byte z;
        byte w;
    }
    else
        Assert(false);
};

struct Vector2(byte type)
{
    if (type == 5)
    {
        short x;
        short y;
    }
    else
        Assert(false);
};

struct Vertex(ushort vertexFlags, ubyte vertexFieldTypes[])
{
    if ((vertexFlags & 0x0001) != 0)
        Vector3 position(vertexFieldTypes[0]);
    if ((vertexFlags & 0x0002) != 0)
        Vector3 tangent(vertexFieldTypes[1]);
    if ((vertexFlags & 0x0004) != 0)
        Vector3 normal(vertexFieldTypes[2]);
    if ((vertexFlags & 0x0008) != 0)
        Vector3 bitangent(vertexFieldTypes[3]);

    if ((vertexFlags & 0x0010) != 0) // boneIndices?
        uint bone;
    if ((vertexFlags & 0x0020) != 0) // boneWeights?
        Assert(false);
    if ((vertexFlags & 0x0040) != 0)
        Vector4 color1(vertexFieldTypes[6]);
    if ((vertexFlags & 0x0080) != 0)
        Vector4 color2(vertexFieldTypes[7]);

    if ((vertexFlags & 0x0100) != 0) // uv2?
        Vector2 uv(vertexFieldTypes[8]);
    if ((vertexFlags & 0x0200) != 0) // uv2?
        Assert(false);
    if ((vertexFlags & 0x0400) != 0)
        Assert(false);
    if ((vertexFlags & 0x0800) != 0)
        Assert(false);

    if ((vertexFlags & 0x1000) != 0)
        Assert(false);
    if ((vertexFlags & 0x2000) != 0)
        Assert(false);
    if ((vertexFlags & 0x4000) != 0)
        Assert(false);
    if ((vertexFlags & 0x8000) != 0)
        Assert(false);
};

struct Mesh
{
    uint startIndex;
    uint startVertex;
    uint indexCount;
    uint vertexCount;
    ushort bonesIndex;
    ushort bonesCount;
    ushort unk1;
    ushort material;
    ushort unk2;
    ushort unk3;
    ushort unk4;
    ushort unk5;
    ushort unk6;
    ushort unk7;
    ushort unk8;
    ushort unk9;
    ushort unk10;
    ushort unk11;
    ushort unk12;
    ushort unk13;
    uint unk14; // TODO color?
    uint unk15; // TODO color?
    uint64 unk16;
    float min[4];
    float max[4];
    float unk17[4]; // origin?
};

struct Geometry
{
    uint64 unk1; // 80
    uint64 unk2; // 0
    uint64 unk3; // 0

    uint vertexCount;
    ushort vertexSize;
    ushort vertexFlags;
    ubyte vertexFieldTypes[11];
    ubyte vertexFieldPositions[11];
    ushort vertexPadding;
    uint64 vertexTotalSize;
    uint64 vertexOffset;

    uint64 unk5; // 0
    uint64 unk6; // 0
    uint64 unk7; // 0
    uint64 unk8; // 0
    
    uint indexCount;
    ubyte indexSize;
    ubyte indexFlags;
    ushort indexPadding;
    uint64 indexTotalSize;
    uint64 indexOffset;
    
    uint64 meshCount;
    uint64 meshOffset;

    uint64 vertexCount2; // TODO this is weird... Verify if there is no other usage!
    Assert(vertexCount == vertexCount2);

    uint64 unk3Count;
    uint64 unk3Offset;
    uint64 unk4Count; // TODO
    uint64 unk4Offset;
    uint64 unk5Count; // TODO LOD?
    uint64 unk5Offset;
    Padding padding;
    
    local int start = FTell();

    Assert(FTell() - start == vertexOffset);
    Vertex vertices(vertexFlags, vertexFieldTypes)[vertexCount]<optimize=false>;
    Padding padding;

    Assert(FTell() - start == indexOffset);

    if (indexFlags == 1)
        ushort indices[indexCount];
    else if (indexFlags == 2)
        uint indices[indexCount];
    else
        Assert(false);

    Padding padding;

    if (meshCount != 0)
    {
        Assert(FTell() - start == meshOffset);
        Mesh mesh[meshCount];
        Padding padding;
    }

    if (unk3Offset != 0)
    {
        Assert(FTell() - start == unk3Offset);
        uint unk3_1[unk3Count]; // TODO parse me!
        Padding padding;
    }
    
    if (unk4Offset != 0)
    {
        Assert(FTell() - start == unk4Offset);
        ushort unk4_1[unk4Count]; // TODO parse me!
        Padding padding;
    }

    if (unk5Offset != 0)
    {
        Assert(FTell() - start == unk5Offset);
        uint unk5_1[unk5Count]; // TODO parse me!
        Padding padding;    
    }

    Padding padding;
};
// Geometry end

struct Unk37
{
    ubyte unk[16]; // TODO parse me!
    Padding padding;
};

struct Unk38
{
    ubyte unk[96]; // TODO parse me!
};

struct Unk51Header
{
    uint64 unk1count;
    uint64 unk1offset;
    uint64 unk2count;
    uint64 unk2offset;
    uint64 unk3count;
    uint64 unk3offset;
    uint64 unk4count;
    uint64 unk4offset;
};

struct Unk51Body(Unk51Header &header, uint start)
{
    Assert(FTell() - start == header.unk1offset);
    byte unk1[header.unk1count * 16]; // TODO
    Padding padding;
    
    Assert(FTell() - start == header.unk2offset);
    byte unk2[header.unk2count * 12]; // TODO
    Padding padding;
    
    Assert(FTell() - start == header.unk3offset);
    byte unk3[header.unk3count * 4]; // TODO
    Padding padding;
    
    Assert(FTell() - start == header.unk4offset);
    byte unk4[header.unk4count * 20]; // TODO
    Padding padding;
};

// TODO we can remove this struct and make a large list of named entries!
// The actual file
struct Chunk
{
    uint64 count;
    uint64 offset;
};

SetBackColor(cGreen);
char magic[4];
uint version;

uint64 unk01; // TODO
Chunk chunks[48];
ubyte unk02[8]; // TODO parse me!
Chunk chunks2[3];
ubyte unk03[328]; // TODO parse me!
Chunk chunks3[2];
ubyte unk04[384]; // TODO parse me!

local int i;
local int j;
for (i = 0; i < 48; i++)
{
    if (chunks[i].count == 0)
        continue;

    // if (i != 2) // TODO just a hack!
    Assert(FTell() == 1584 + chunks[i].offset);

    if (i == 0) // Bounds
    {
        Unk0 unk0[chunks[i].count]<optimize=false>;
        // TODO there can be strings here?!
        // byte hack0[400]; // TODO remove
    }
    else if (i == 1)
        byte unk1[chunks[i].count * 4]<optimize=false>; // TODO
    else if (i == 2)
    {
        // TODO this one is weird! it has no count, but offset is stored as count?!
        byte unk2[64]<optimize=false>; // TODO
    }
    else if (i == 3)
        Assert(false);
    else if (i == 4)
        Assert(false);
    else if (i == 5)
        Assert(false);
    else if (i == 6)
        Assert(false);
    else if (i == 7)
        byte unk7[chunks[i].count * 48]<optimize=false>; // TODO
    else if (i == 8)
        Assert(false);
    else if (i == 9)
        Assert(false);
    else if (i == 10)
        Assert(false);
    else if (i == 11)
        Assert(false);
    else if (i == 12)
        Assert(false);
    else if (i == 13)
        Assert(false);
    else if (i == 14)
        Unk14 unk14[chunks[i].count]<optimize=false>;
    else if (i == 15)
        Assert(false);
    else if (i == 16)
        Assert(false);
    else if (i == 17)
        Assert(false);
    else if (i == 18)
        Assert(false);
    else if (i == 19)
        Assert(false);
    else if (i == 20)
        Assert(false);
    else if (i == 21)
        Assert(false);
    else if (i == 22)
        Assert(false);
    else if (i == 23)
    {
        Bone bone[chunks[i].count]<optimize=false>;

        for (j = 0; j < chunks[i].count; j++)
            BoneAnimations boneAnimations(bone[j]);
    }
    else if (i == 24)
        Assert(false);
    else if (i == 25)
        Assert(false);
    else if (i == 26) // BoneMapping
        Unk26 unk26(chunks[i].count)<optimize=false>;
    else if (i == 27)
    {
        Texture texture[chunks[i].count]<optimize=false>;
        TexturePath texturePath[chunks[i].count]<optimize=false>;
    }
    else if (i == 28)
        Assert(false);
    else if (i == 29)
        Assert(false);
    else if (i == 30)
    {
        MaterialHeader materialHeader[chunks[i].count]<optimize=false>;
        
        for (j = 0; j < chunks[i].count; j++)
            MaterialLayers materialLayers(materialHeader[j].layers)<optimize=false>;
    }
    else if (i == 31)
        Assert(false);
    else if (i == 32)
        Assert(false);
    else if (i == 33)
        Assert(false);
    else if (i == 34)
        Assert(false);
    else if (i == 35)
        Assert(false);
    else if (i == 36)
        Geometry geometry[chunks[i].count]<optimize=false>;
    else if (i == 37)
        Unk37 unk37[chunks[i].count]<optimize=false>;
    else if (i == 38)
        Unk38 unk38[chunks[i].count]<optimize=false>;
    else if (i == 39)
        Assert(false);
    else if (i == 40)
        Assert(false);
    else if (i == 41)
        Assert(false);
    else if (i == 42)
        Assert(false);
    else if (i == 43)
        Assert(false);
    else if (i == 44)
        Assert(false);
    else if (i == 45)
        Assert(false);
    else if (i == 46)
        Assert(false);
    else if (i == 47)
        Assert(false);
}

for (i = 0; i < 3; i++)
{
    if (chunks2[i].count == 0)
        continue;

    Assert(FTell() == 1584 + chunks2[i].offset);
    
    if (i == 0)
    {
        byte unk48[chunks2[i].count * 552]<optimize=false>; // TODO
        Padding padding;
    }
    else if (i == 1)
    {
        byte unk49[chunks2[i].count * 96]<optimize=false>; // TODO
        Padding padding;
    }
    else if (i == 2)
    {
        byte unk50[chunks2[i].count * 4]<optimize=false>; // TODO
        Padding padding;
    }
}

for (i = 0; i < 2; i++)
{
    if (chunks3[i].count == 0)
        continue;

    Assert(FTell() == 1584 + chunks3[i].offset);
    
    if (i == 0)
    {
        Unk51Header unk51Header[chunks3[i].count];
        local int start = FTell();
        
        for (j = 0; j < chunks3[i].count; j++)
            Unk51Body unk51Body(unk51Header[j], start);
    }
    else if (i == 2)
        Assert(false);
}
    
Assert(FEof());
