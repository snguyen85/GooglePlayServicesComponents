﻿using System;
using System.Threading.Tasks;
using Android.Gms.Extensions;

namespace Android.Gms.Location.Places
{
	public partial class GeoDataClient
	{
		public virtual Task<PlacePhotoResponse> GetPhotoAsync(IPlacePhotoMetadata photoMetadata)
		{
			return GetPhoto(photoMetadata).AsAsync<PlacePhotoResponse>();
		}

		public virtual Task<PlacePhotoMetadataResponse> GetPlacePhotosAsync(string placeId)
		{
			return GetPlacePhotos(placeId).AsAsync<PlacePhotoMetadataResponse>();
		}

		public virtual Task<PlacePhotoResponse> GetScaledPhotoAsync(IPlacePhotoMetadata photoMetadata, int width, int height)
		{
			return GetScaledPhoto(photoMetadata, width, height).AsAsync<PlacePhotoResponse>();
		}
	}

	public partial class PlaceDetectionClient
	{
		public Task ReportDeviceAtPlaceAsync(PlaceReport report)
		{
			return ReportDeviceAtPlace(report).AsAsync();
		}

		public Task<PlaceLikelihoodBufferResponse> GetCurrentPlaceAsync(PlaceFilter placeFilter)
		{
			return GetCurrentPlace(placeFilter).AsAsync<PlaceLikelihoodBufferResponse>();
		}
	}
}
