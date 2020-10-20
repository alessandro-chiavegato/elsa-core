using System.Threading;
using System.Threading.Tasks;
using Elsa.Models;

namespace Elsa.Services
{
    public interface IWorkflowPublisher
    {
        WorkflowDefinition New();
        
        Task<WorkflowDefinition?> PublishAsync(string workflowDefinitionId, CancellationToken cancellationToken = default);

        Task<WorkflowDefinition> PublishAsync(
            WorkflowDefinition workflowDefinition,
            CancellationToken cancellationToken = default);

        Task<WorkflowDefinition?> GetDraftAsync(string workflowDefinitionId, CancellationToken cancellationToken= default);

        Task<WorkflowDefinition> SaveDraftAsync(
            WorkflowDefinition workflowDefinition,
            CancellationToken cancellationToken = default);
    }
}