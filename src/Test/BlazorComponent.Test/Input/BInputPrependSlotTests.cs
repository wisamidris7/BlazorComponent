﻿using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorComponent.Test.Input
{
    [TestClass]
    public class BInputPrependSlotTests : TestBase
    {
        [TestMethod]
        public void RenderShouldHasAsbstractComponent()
        {
            // Arrange
            var mock = new Mock<IInput>();
            mock.Setup(r => r.PrependIcon).Returns("mdi-clear");
            mock.Setup(r => r.AbstractProvider).Returns(new ComponentAbstractProvider());

            // Act
            var cut = RenderComponent<BInputPrependSlot<IInput>>(props =>
            {
                props
                    .Add(p => p.AbstractComponent, mock.Object);
            });

            // Assert
            cut.MarkupMatches("");
            cut.HasComponent<AbstractComponent>();
        }
    }
}
