//-----------------------------------------------------------------------
// <copyright file="ShortListingsWrapperTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests.RTE
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ShortListingsWrapperTests
    {
        [TestMethod]
        public void ShortListingsWrapper_ctor()
        {
            var sut = new ShortListingsWrapper();

            sut.Should().NotBeNull();
            sut.Should().BeOfType<ShortListingsWrapper>();
        }

        [TestMethod]
        public async Task GetRte1ShortListingAsync_Succeeds()
        {
            var sut = new ShortListingsWrapper();

            var rte1Results = await sut.GetRte1ShortListingAsync();

            rte1Results.Should().NotBeNull();
            rte1Results.Should().BeOfType<ShortListing>();
            rte1Results.Item.Count.Should().BeGreaterThan(0);

            var firstResult = rte1Results.Item[0];
            firstResult.Should().NotBeNull();
            firstResult.Should().BeOfType<Item>();
            firstResult.Asset.Should().NotBeNull();

            var asset = firstResult.Asset;
            asset.Should().NotBeNull();
            asset.Should().BeOfType<Asset>();
            asset.Attribute.Should().NotBeNull();
            asset.Category.Should().NotBeNull();

            var category = asset.Category;
            category.Should().BeOfType<List<Category>>();
            category.Count.Should().BeGreaterThanOrEqualTo(0);
            if (category.Count > 0)
            {
                var firstCategory = category[0];
                firstCategory.Should().NotBeNull();
                firstCategory.Should().BeOfType<Category>();
                firstCategory.Code.Should().NotBeNullOrWhiteSpace();
                firstCategory.Dvb.Should().NotBeNullOrWhiteSpace();
                firstCategory.Name.Should().NotBeNullOrWhiteSpace();
            }

            asset.Certification.Should().NotBeNull();
            var certification = asset.Certification;
            certification.Should().NotBeNull();
            certification.Should().BeOfType<Certification>();
            if (certification.Bbfc != null)
            {
                certification.Bbfc.Should().NotBeNull(); // Can be empty.
            }

            asset.Contributor.Should().NotBeNull();
            var contributor = asset.Contributor;
            contributor.Should().BeOfType<List<Contributor>>();

            contributor.Count.Should().BeGreaterThanOrEqualTo(0);
            if (contributor.Count > 0)
            {
                var firstContributor = contributor[0];
                firstContributor.Should().NotBeNull();
                firstContributor.Should().BeOfType<Contributor>();
                firstContributor.Dob.Should().NotBeNullOrWhiteSpace();
                firstContributor.Character.Should().NotBeNull();
                firstContributor.Gender.Should().NotBeNullOrWhiteSpace();
                firstContributor.From.Should().NotBeNullOrWhiteSpace();
                firstContributor.Id.Should().NotBeNullOrWhiteSpace();
                firstContributor.Media.Should().NotBeNull();
                firstContributor.Meta.Should().NotBeNull();
                firstContributor.Name.Should().NotBeNullOrWhiteSpace();
                firstContributor.Role.Should().NotBeNull();
                firstContributor.Subject.Should().NotBeNull();
            }

            asset.Deeplink.Should().NotBeNull();
            asset.Id.Should().NotBeNullOrWhiteSpace();
            asset.Link.Should().NotBeNull();
            if (asset.Number.HasValue)
            {
                asset.Number.Value.Should().BeGreaterThanOrEqualTo(0);
            }
            asset.Related.Should().NotBeNull();
            if (asset.Runtime.HasValue)
            {
                asset.Runtime.Should().NotBeNull();
            }
            asset.Subject.Should().NotBeNull();
            asset.Summary.Should().NotBeNull();
            asset.Title.Should().NotBeNullOrWhiteSpace();
            if (asset.Total.HasValue)
            {
                asset.Total.Should().NotBeNull();
            }
            asset.Type.Should().NotBeNullOrWhiteSpace();

            firstResult.Attribute.Count.Should().BeGreaterThan(0);
            firstResult.Certification.Should().NotBeNull();
            firstResult.DateTime.Should().BeAfter(DateTime.UtcNow.AddDays(-1));
            if (!firstResult.Duration.HasValue)
            {
                firstResult.Duration.Should().BeNull();
            }
            else
            {
                firstResult.Duration.Should().BeGreaterThan(0);
            }
            firstResult.Id.Should().NotBeNullOrWhiteSpace();
            firstResult.Meta.Should().NotBeNull();
            firstResult.Summary.Should().NotBeNull();
            firstResult.Title.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task GetRte2ShortListingAsync_Succeeds()
        {
            var sut = new ShortListingsWrapper();

            var rte2Results = await sut.GetRte2ShortListingAsync();

            rte2Results.Should().NotBeNull();
            rte2Results.Should().BeOfType<ShortListing>();
            rte2Results.Item.Count.Should().BeGreaterThan(0);

            var firstResult = rte2Results.Item[0];
            firstResult.Should().NotBeNull();
            firstResult.Should().BeOfType<Item>();

            var asset = firstResult.Asset;
            asset.Should().NotBeNull();
            asset.Should().BeOfType<Asset>();
            asset.Attribute.Should().NotBeNull();
            asset.Category.Should().NotBeNull();

            var category = asset.Category;
            category.Should().BeOfType<List<Category>>();
            category.Count.Should().BeGreaterThanOrEqualTo(0);
            if (category.Count > 0)
            {
                var firstCategory = category[0];
                firstCategory.Should().NotBeNull();
                firstCategory.Should().BeOfType<Category>();
                firstCategory.Code.Should().NotBeNullOrWhiteSpace();
                firstCategory.Dvb.Should().NotBeNullOrWhiteSpace();
                firstCategory.Name.Should().NotBeNullOrWhiteSpace();
            }

            asset.Certification.Should().NotBeNull();
            var certification = asset.Certification;
            certification.Should().NotBeNull();
            certification.Should().BeOfType<Certification>();
            if (certification.Bbfc != null)
            {
                certification.Bbfc.Should().NotBeNull(); // Can be empty.
            }

            asset.Contributor.Should().NotBeNull();
            var contributor = asset.Contributor;
            contributor.Should().BeOfType<List<Contributor>>();

            contributor.Count.Should().BeGreaterThanOrEqualTo(0);

            contributor.Count.Should().BeGreaterThanOrEqualTo(0);
            if (contributor.Count > 0)
            {
                var firstContributor = contributor[0];
                firstContributor.Should().NotBeNull();
                firstContributor.Should().BeOfType<Contributor>();
                firstContributor.Dob.Should().NotBeNullOrWhiteSpace();
                firstContributor.Character.Should().NotBeNull();
                firstContributor.Gender.Should().NotBeNullOrWhiteSpace();
                firstContributor.From.Should().NotBeNullOrWhiteSpace();
                firstContributor.Id.Should().NotBeNullOrWhiteSpace();
                firstContributor.Media.Should().NotBeNull();
                firstContributor.Meta.Should().NotBeNull();
                firstContributor.Name.Should().NotBeNullOrWhiteSpace();
                firstContributor.Role.Should().NotBeNull();
                firstContributor.Subject.Should().NotBeNull();
            }

            asset.Deeplink.Should().NotBeNull();
            asset.Id.Should().NotBeNullOrWhiteSpace();
            asset.Link.Should().NotBeNull();
            if (asset.Number.HasValue)
            {
                asset.Number.Value.Should().BeGreaterThanOrEqualTo(0);
            }
            asset.Related.Should().NotBeNull();
            if (asset.Runtime.HasValue)
            {
                asset.Runtime.Should().NotBeNull();
            }
            asset.Subject.Should().NotBeNull();
            asset.Summary.Should().NotBeNull();
            asset.Title.Should().NotBeNull();
            if (asset.Total.HasValue)
            {
                asset.Total.Should().NotBeNull();
            }
            asset.Type.Should().NotBeNullOrWhiteSpace();

            firstResult.Attribute.Count.Should().BeGreaterThan(0);
            firstResult.Certification.Should().NotBeNull();
            firstResult.DateTime.Should().BeAfter(DateTime.UtcNow.AddDays(-1));
            if (!firstResult.Duration.HasValue)
            {
                firstResult.Duration.Should().BeNull();
            }
            else
            {
                firstResult.Duration.Should().BeGreaterThan(0);
            }

            firstResult.Id.Should().NotBeNullOrWhiteSpace();
            firstResult.Meta.Should().NotBeNull();
            firstResult.Summary.Should().NotBeNull();
            firstResult.Title.Should().NotBeNullOrWhiteSpace();
        }
    }
}