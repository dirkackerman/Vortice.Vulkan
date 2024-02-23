// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#pragma warning disable CS0649
namespace Vortice.Vulkan;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaDeviceMemoryCallbacks
{
	public delegate* unmanaged<VmaAllocator, uint, VkDeviceMemory, ulong, void*, void> pfnAllocate;
	public delegate* unmanaged<VmaAllocator, uint, VkDeviceMemory, ulong, void*, void> pfnFree;
	public void* pUserData;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaVulkanFunctions
{
	public delegate* unmanaged<VkInstance, sbyte*, IntPtr> vkGetInstanceProcAddr;
	public delegate* unmanaged<VkDevice, sbyte*, IntPtr> vkGetDeviceProcAddr;
	public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> vkGetPhysicalDeviceProperties;
	public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> vkGetPhysicalDeviceMemoryProperties;
	public delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult> vkAllocateMemory;
	public delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> vkFreeMemory;
	public delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlags, void*, VkResult> vkMapMemory;
	public delegate* unmanaged<VkDevice, VkDeviceMemory, void> vkUnmapMemory;
	public delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkFlushMappedMemoryRanges;
	public delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkInvalidateMappedMemoryRanges;
	public delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult> vkBindBufferMemory;
	public delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult> vkBindImageMemory;
	public delegate* unmanaged<VkDevice, VkBuffer, VkMemoryRequirements*, void> vkGetBufferMemoryRequirements;
	public delegate* unmanaged<VkDevice, VkImage, VkMemoryRequirements*, void> vkGetImageMemoryRequirements;
	public delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> vkCreateBuffer;
	public delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void> vkDestroyBuffer;
	public delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> vkCreateImage;
	public delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void> vkDestroyImage;
	public delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> vkCmdCopyBuffer;
	public delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetBufferMemoryRequirements2KHR;
	public delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetImageMemoryRequirements2KHR;
	public delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2KHR;
	public delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2KHR;
	public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> vkGetPhysicalDeviceMemoryProperties2KHR;
	public delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirements;
	public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirements;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaAllocatorCreateInfo
{
	public VmaAllocatorCreateFlags flags;
	public VkPhysicalDevice physicalDevice;
	public VkDevice device;
	public ulong preferredLargeHeapBlockSize;
	public VkAllocationCallbacks* pAllocationCallbacks;
	public VmaDeviceMemoryCallbacks* pDeviceMemoryCallbacks;
	public ulong* pHeapSizeLimit;
	public VmaVulkanFunctions* pVulkanFunctions;
	public VkInstance instance;
	public VkVersion vulkanApiVersion;
	public VkExternalMemoryHandleTypeFlagsKHR* pTypeExternalMemoryHandleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaAllocatorInfo
{
	public VkInstance instance;
	public VkPhysicalDevice physicalDevice;
	public VkDevice device;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaStatistics
{
	public uint blockCount;
	public uint allocationCount;
	public ulong blockBytes;
	public ulong allocationBytes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaDetailedStatistics
{
	public VmaStatistics statistics;
	public uint unusedRangeCount;
	public ulong allocationSizeMin;
	public ulong allocationSizeMax;
	public ulong unusedRangeSizeMin;
	public ulong unusedRangeSizeMax;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaTotalStatistics
{
	public memoryType__FixedBuffer memoryType;

#if NET8_0_OR_GREATER
	[InlineArray(32)]
	public partial struct memoryType__FixedBuffer
	{
		public VmaDetailedStatistics e0;
	}
#else
	public unsafe struct memoryType__FixedBuffer
	{
		public VmaDetailedStatistics e0;
		public VmaDetailedStatistics e1;
		public VmaDetailedStatistics e2;
		public VmaDetailedStatistics e3;
		public VmaDetailedStatistics e4;
		public VmaDetailedStatistics e5;
		public VmaDetailedStatistics e6;
		public VmaDetailedStatistics e7;
		public VmaDetailedStatistics e8;
		public VmaDetailedStatistics e9;
		public VmaDetailedStatistics e10;
		public VmaDetailedStatistics e11;
		public VmaDetailedStatistics e12;
		public VmaDetailedStatistics e13;
		public VmaDetailedStatistics e14;
		public VmaDetailedStatistics e15;
		public VmaDetailedStatistics e16;
		public VmaDetailedStatistics e17;
		public VmaDetailedStatistics e18;
		public VmaDetailedStatistics e19;
		public VmaDetailedStatistics e20;
		public VmaDetailedStatistics e21;
		public VmaDetailedStatistics e22;
		public VmaDetailedStatistics e23;
		public VmaDetailedStatistics e24;
		public VmaDetailedStatistics e25;
		public VmaDetailedStatistics e26;
		public VmaDetailedStatistics e27;
		public VmaDetailedStatistics e28;
		public VmaDetailedStatistics e29;
		public VmaDetailedStatistics e30;
		public VmaDetailedStatistics e31;

		[UnscopedRef]
		public ref VmaDetailedStatistics this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ref Unsafe.Add(ref e0, index);
			}
		}

		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<VmaDetailedStatistics> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
	}
#endif
	public memoryHeap__FixedBuffer memoryHeap;

#if NET8_0_OR_GREATER
	[InlineArray(16)]
	public partial struct memoryHeap__FixedBuffer
	{
		public VmaDetailedStatistics e0;
	}
#else
	public unsafe struct memoryHeap__FixedBuffer
	{
		public VmaDetailedStatistics e0;
		public VmaDetailedStatistics e1;
		public VmaDetailedStatistics e2;
		public VmaDetailedStatistics e3;
		public VmaDetailedStatistics e4;
		public VmaDetailedStatistics e5;
		public VmaDetailedStatistics e6;
		public VmaDetailedStatistics e7;
		public VmaDetailedStatistics e8;
		public VmaDetailedStatistics e9;
		public VmaDetailedStatistics e10;
		public VmaDetailedStatistics e11;
		public VmaDetailedStatistics e12;
		public VmaDetailedStatistics e13;
		public VmaDetailedStatistics e14;
		public VmaDetailedStatistics e15;

		[UnscopedRef]
		public ref VmaDetailedStatistics this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ref Unsafe.Add(ref e0, index);
			}
		}

		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<VmaDetailedStatistics> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
	}
#endif
	public VmaDetailedStatistics total;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaBudget
{
	public VmaStatistics statistics;
	public ulong usage;
	public ulong budget;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaAllocationCreateInfo
{
	public VmaAllocationCreateFlags flags;
	public VmaMemoryUsage usage;
	public VkMemoryPropertyFlags requiredFlags;
	public VkMemoryPropertyFlags preferredFlags;
	public uint memoryTypeBits;
	public VmaPool pool;
	public void* pUserData;
	public float priority;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaPoolCreateInfo
{
	public uint memoryTypeIndex;
	public VmaPoolCreateFlags flags;
	public ulong blockSize;
	public nuint minBlockCount;
	public nuint maxBlockCount;
	public float priority;
	public ulong minAllocationAlignment;
	public void* pMemoryAllocateNext;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaAllocationInfo
{
	public uint memoryType;
	public VkDeviceMemory deviceMemory;
	public ulong offset;
	public ulong size;
	public void* pMappedData;
	public void* pUserData;
	public sbyte* pName;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaAllocationInfo2
{
	public VmaAllocationInfo allocationInfo;
	public ulong blockSize;
	public VkBool32 dedicatedMemory;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaDefragmentationInfo
{
	public VmaDefragmentationFlags flags;
	public VmaPool pool;
	public ulong maxBytesPerPass;
	public uint maxAllocationsPerPass;
	public delegate* unmanaged<void*, uint> pfnBreakCallback;
	public void* pBreakCallbackUserData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaDefragmentationMove
{
	public VmaDefragmentationMoveOperation operation;
	public VmaAllocation srcAllocation;
	public VmaAllocation dstTmpAllocation;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaDefragmentationPassMoveInfo
{
	public uint moveCount;
	public VmaDefragmentationMove* pMoves;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VmaDefragmentationStats
{
	public ulong bytesMoved;
	public ulong bytesFreed;
	public uint allocationsMoved;
	public uint deviceMemoryBlocksFreed;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaVirtualBlockCreateInfo
{
	public ulong size;
	public VmaVirtualBlockCreateFlags flags;
	public VkAllocationCallbacks* pAllocationCallbacks;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaVirtualAllocationCreateInfo
{
	public ulong size;
	public ulong alignment;
	public VmaVirtualAllocationCreateFlags flags;
	public void* pUserData;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VmaVirtualAllocationInfo
{
	public ulong offset;
	public ulong size;
	public void* pUserData;
}

