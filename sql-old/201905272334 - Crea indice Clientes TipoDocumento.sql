-- Creating foreign key on [IdTipoDocumento] in table 'Proveedores'
use ERP_Dev

ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_Clientes_TiposDocumento]
    FOREIGN KEY ([IdTipoDocumento])
    REFERENCES [dbo].[TiposDocumento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proveedores_TiposDocumento'
CREATE INDEX [IX_FK_Clientes_TiposDocumento]
ON [dbo].[Clientes]
    ([IdTipoDocumento]);
GO